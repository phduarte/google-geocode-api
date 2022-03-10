using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using WappaMobile.ChallengeDev.Models;

namespace WappaMobile.ChallengeDev.GoogleMaps
{
    internal class GoogleMapsGeoCodeFacade : IGeoCodeFacade
    {
        private readonly GoogleMapsOptions _options;

        public GoogleMapsGeoCodeFacade(GoogleMapsOptions options)
        {
            _options = options;
        }

        public async Task<Coordinate> SearchAsync(Address address)
        {
            if (address == null || !address.IsValid)
                throw new ArgumentNullException(nameof(address));

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_options.BaseUrl);
                var result = await client.GetAsync($@"json?address={address}&key={_options.ApiKey}");

                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var e = JsonConvert.DeserializeObject<GeoCode>(content);

                    if (e.status.Equals("REQUEST_DENIED"))
                        throw new GoogleMapsRequestDeniedExcepion("Check the API_KEY.");
                    else
                    {
                        var c = new Coordinate(e.lat, e.lng);

                        if (!c.IsEmpty)
                            return c;
                    }
                }
            }

            throw new AddressNotFoundException(address);
        }
    }
}
