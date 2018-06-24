using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExmoTakeProfit
{
    /// <summary>
    /// Класс, экземпляр которго содержит информацию о запросах, 
    /// которые необходимо выполнить, компанует их, 
    /// выставляет приоритеты, выполняет запросы.
    /// Инициализируется при создании главного окна.
    /// </summary>
    class APIConnectionPool
    {
        /// <summary>
        ////переменная патерна одиночка
        /// </summary>
        private static APIConnectionPool instance;
        /// <summary>
        /// метод, реализующик патерн одиночка
        /// </summary>
        /// <returns></returns>
        public static APIConnectionPool getInstance()
        {
            if (instance == null)
                instance = new APIConnectionPool();
            return instance;
        }

        /// <summary>
        /// конструктор класса
        /// </summary>
        private APIConnectionPool()
        {

        }

        /// <summary>
        /// служебные функции для осуществления запросов к бирже 
        /// </summary>
        public async Task<string> ApiQueryAsync(string apiName, IDictionary<string, string> req)
        {
            using (var client = new HttpClient())
            {

                var content = new FormUrlEncodedContent(req);
                var response = await client.PostAsync(string.Format(_url, apiName), content);

                return await response.Content.ReadAsStringAsync();
            }
        }

        /* сделали запрос */
        //var task = ApiQueryAsync(apiName, new Dictionary<string, string>());

        /*
         * создание задачи на запрос
         * orderBook = new Task(() => ThreadProcSafe("https://api.exmo.com/v1/order_book/?pair=" + coinPair, "order_book"));
         * orderBook.Start();
         */
    }
}
