using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static UnitTestProject2.TrelloRoot;

namespace UnitTestProject2
{
    class TrelloService
    {
        private async Task<string> Get(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.GetAsync(url))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }

        private async Task<string> Post(string url)
        {
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage response = await client.PostAsync(url, null))
            using (HttpContent content = response.Content)
            {
                if (!response.IsSuccessStatusCode)
                    throw new Exception(response.ReasonPhrase);

                return await content.ReadAsStringAsync();
            }
        }

        internal async Task<List<Rootobject>> GetAllBoards()
        {
            string page = "https://api.trello.com/1/members/me/boards?key=ecde2d0ee1b1bcbbd8a4ddb383616c01&token=d8c4c7eacf780fdf4988efc80caa9c2c229995f31d1d0b2437b0ea83c27afbcf";
            var result = await Get(page);
            return JsonConvert.DeserializeObject<List<Rootobject>>(result);
        }

        internal async Task<List<Rootobject>> GetAllListsForBoard(string v)
        {
            string page = "https://api.trello.com/1/boards/" + v + "/lists?key=ecde2d0ee1b1bcbbd8a4ddb383616c01&token=d8c4c7eacf780fdf4988efc80caa9c2c229995f31d1d0b2437b0ea83c27afbcf";
            var result = await Get(page);
            return JsonConvert.DeserializeObject<List<Rootobject>>(result);
        }

        internal async Task CreateAcardOnAlist(string v1, string v2, string v3)
        {
            string page = "https://api.trello.com/1/cards?name=" + v2 + "&desc=" + v3 + "&pos=top&idList=" + v1 + "&keepFromSource=all&key=ecde2d0ee1b1bcbbd8a4ddb383616c01&token=d8c4c7eacf780fdf4988efc80caa9c2c229995f31d1d0b2437b0ea83c27afbcf";
            var result = await Post(page);
        }
    }
}
