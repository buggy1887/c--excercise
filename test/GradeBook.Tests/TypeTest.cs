using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void CSharpCanPassByRef()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName1(out book1, "New Name");

            //act

            //assert
            Assert.Equal("New Name", book1.Name);
          
        }

        // difference between ref and out is that in out we must initalize output parametre
        private void GetBookSetName1(out Book book, string name)
        {
            book = new Book(name);
        }
        public void PassByValue()
        {
            //arrange
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            //act

            //assert
            Assert.Equal("Book 1", book1.Name);
          
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
        [Fact]
        public void CanSetNameFromReference()
        {
            //arrange
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            //act

            //assert
            Assert.Equal("New Name", book1.Name);
          
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //act

            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;

            //act

            //assert
            Assert.Same(book1, book2);


        }
        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
