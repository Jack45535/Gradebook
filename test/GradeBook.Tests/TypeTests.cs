using System;
using Gradebook;
using Xunit;


namespace GradeBook.Tests
{


    public class TypeTests
        {
                [Fact]
                public void StringsBehaveLikeValueTypes()
                {
                    string name = "Jack";
                    MakeUpperCase(name);
                    var upper = MakeUpperCase(name);
                    Assert.Equal("Jack", name);
                    Assert.Equal("JACK", upper);
                }
                private string MakeUpperCase(string paramater)
                {
                  return  paramater.ToUpper();
                }

                [Fact]
    public void Test1()
    {
        var x = GetInt();
        SetInt(ref x);

        Assert.Equal(42,x);
    }

        private void SetInt(ref int x)
        {
            x=42;
        }

        private int GetInt()
    {
        return 3;
    }
                            [Fact]

        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(out book1,"New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(out Book book, string name)
        {
           book = new Book(name);

        }
                [Fact]

        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1,"New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
           book = new Book(name);
           book.Name = name;

        }

        [Fact]

        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1,"New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
           book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferntObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);
        }
         
         
                [Fact]
        public void TwoVarsCanREferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
