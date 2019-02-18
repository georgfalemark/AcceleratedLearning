using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void get_all_boards()
        {
            var service = new TrelloService();
            var result = service.GetAllBoards().Result;
        }

        [TestMethod]
        public void get_all_lists_for_a_specific_board()
        {
            var ts = new TrelloService();
            var result = ts.GetAllListsForBoard("gBKb3qlq").Result;
        }

        [TestMethod]
        public void add_a_post_to_a_specific_list()
        {
            var ts = new TrelloService();
            ts.CreateAcardOnAlist("5c643b0db4e6e389eb3cb840", "Testar att posta fr C skarp!", "Testar att poooosta från C skarp!").Wait();
        }

    }
}
