using System;
using Xunit;

namespace WappaMobile.ChallengeDev.Models
{
    public class NameTest
    {
        [Fact]
        public void ShouldAllowSurname()
        {
            var nome = new Name("Paulo", "Duarte");
            Assert.True("Paulo Duarte".Equals(nome));
        }

        [Fact]
        public void ShouldConcatenateFullName()
        {
            var nome = new Name("Paulo Henrique", "Fernandes Duarte");
            Assert.True("Paulo Henrique Fernandes Duarte" == nome);
        }

        [Fact]
        public void ShouldGetFirstName()
        {
            var nome = new Name("Paulo", "Duarte");
            Assert.Equal("Paulo", nome.FirstName);

            var nomecompleto = new Name("Paulo Henrique Fernandes Duarte");
            Assert.Equal("Paulo Henrique", nomecompleto.FirstName);
        }

        [Fact]
        public void ShouldGetLastName()
        {
            var nome = new Name("Paulo", "Duarte");
            Assert.Equal("Duarte", nome.LastName);

            var nomecompleto = new Name("Paulo Henrique Fernandes Duarte");
            Assert.Equal("Fernandes Duarte", nomecompleto.LastName);
        }

        [Fact]
        public void ShouldNotInstanciateNamesWithFirstNameEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Name("", "Duarte"));
        }

        [Fact]
        public void ShouldNotInstanciateNameWithLastNameEmpty()
        {
            Assert.Throws<ArgumentException>(() => new Name("Paulo", ""));
        }

        [Fact]
        public void ShouldNotInstanciateNamesWithNumberics()
        {
            Assert.Throws<ArgumentException>(() => new Name("Paulo123"));
        }

        [Fact]
        public void ShouldConvertImplictToString()
        {
            Name nomecompleto = "Paulo Henrique Fernandes Duarte";
            Assert.Equal(nomecompleto, "Paulo Henrique Fernandes Duarte");
        }

        [Fact]
        public void ShouldDisplayToString()
        {
            Name nomecompleto = "Paulo Henrique Fernandes Duarte";
            Assert.Equal(nomecompleto.ToString(), "Paulo Henrique Fernandes Duarte");
        }

        [Fact]
        public void ShouldRecognizeNameWithoutSurname()
        {
            Name nomecompleto = "Paulo";
            Assert.Equal(nomecompleto, "Paulo");
        }

        [Fact]
        public void ShouldRecognizeNameWithSurname()
        {
            Name nomecompleto = "Paulo Duarte";
            Assert.Equal(nomecompleto, "Paulo Duarte");
        }

        [Fact]
        public void ShouldRecognizeNameWithMidname()
        {
            Name nomecompleto = "Paulo Henrique Duarte";
            Assert.True(nomecompleto.Equals("Paulo Henrique Duarte"));
        }

        [Fact]
        public void ShouldThrowExceptionWhenNameContainsNumber()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Name nomecompleto = "Paulo Duart3";
            });
        }

        [Fact]
        public void ShouldInstantiateWithoutArguments()
        {
            var name = new Name();
            name.FirstName = "Paulo";
            name.LastName = "Duarte";

            Assert.Equal("Paulo Duarte", name);
        }
    }
}
