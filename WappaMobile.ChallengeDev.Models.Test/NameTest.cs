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
    }
}
