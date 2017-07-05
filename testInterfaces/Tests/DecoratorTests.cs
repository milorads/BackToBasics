using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using testInterfaces.Design_Patterns.Structural;

namespace testInterfaces.Design_Patterns.Behavioral
{
    class DecoratorTests
    {
        [Test]
        public static void TestConcreteDecorators()
        {
            var c = new ConcreteComponent();
            var d1 = new ConcreteDecoratorA();
            var d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);

            StringAssert.AreEqualIgnoringCase(d2.Operation(true), "ConcreteDecoratorB.Operation()ConcreteDecoratorA.Operation()ConcreteComponent.Operation()");
        }
        [Test]
        public static void TestBorrowables()
        {
            var book = new Book("Worley", "Inside ASP.NET", 10);
            var bookProps = book.Display(true);
            Assert.True(bookProps.Contains("Worley") || bookProps.Contains("Inside ASP.NET") || bookProps.Contains("10"));

            var video = new Video("Spielberg", "Jaws", 23, 92);
            var videoProps = video.Display(true);
            Assert.True(videoProps.Contains("Spielberg") || videoProps.Contains("Jaws") || videoProps.Contains("23") || videoProps.Contains("92"));

            var borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            var borrowProps = borrowvideo.Display(true);
            Assert.True(borrowProps.Contains("Customer #1") || borrowProps.Contains("Customer #2"));
        }
    }
}
