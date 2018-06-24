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
        /// максимально количество запросов в минуту
        /// </summary>
        private int countRequestToMin = 0;

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
        /// служебные функции для осуществления запросов к бирже без авторзации
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

        /// <summary>
        /// метод добавления запросов к бирже, которым требуется авторизация
        /// </summary>
        /// <returns></returns>
        public string AuthorizationRequest()
        {
            return "";
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
