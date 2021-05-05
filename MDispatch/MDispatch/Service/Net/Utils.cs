using MDispatch.Helpers;
using MDispatch.NewElement.ToastNotify;
using MDispatch.Service.Helpers;
using MDispatch.Service.RequestQueue;
using MDispatch.Service.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MDispatch.Service.Net
{
    public class Utils
    {
        [Obsolete]
        public static async Task CheckNet(bool isInspection = false, bool isQueue = false)
        {
            var sync = SynchronizationContext.Current;
            IRestResponse response = null;
            string content = null;
            try
            {
                RestClient client = new RestClient(Config.BaseReqvesteUrl);
                RestRequest request = new RestRequest("Mobile/Net", Method.GET);
                request.AddHeader("Accept", "application/json");
                client.Timeout = 3000;
                response = client.Execute(request);
                content = response.Content;

                if (content == "" || response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    if (App.isNetwork)
                    {
                        TaskManager.isWorkTask = false;
                        App.isNetwork = false;
                    }
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        HelpersView.CallError(LanguageHelper.NotNetworkAlert);
                    });
                }
                else
                {
                    bool isCheck = false;
                    string description = null;
                    GetData(content, ref isCheck, ref description);
                    if (!isCheck)
                    {
                        if (App.isNetwork)
                        {
                            TaskManager.isWorkTask = false;
                            App.isNetwork = false;
                        }
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            HelpersView.CallError(description);
                        });
                    }
                    else
                    {
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            HelpersView.Hidden();
                        });
                        //if (!TaskManager.isWorkTask)
                        //{
                        //    TaskManager.CommandToDo("CheckTask");
                        //}
                        //if (!isQueue)
                        //{
                        //    await ManagerQueue.AddReqvest("", null);
                        //}
                        TaskManager.isWorkTask = true;
                        App.isNetwork = true;
                    }
                }
            }
            catch (Exception e)
            {
                App.isNetwork = false;
            }
        }

        private static void GetData(string respJsonStr, ref bool isCheck, ref string description)
        {
            if(respJsonStr[0] == '!')
            {
                isCheck = false;
                description = "Technical work on the service";
                return;
            }
            respJsonStr = respJsonStr.Replace("\\", "");
            respJsonStr = respJsonStr.Remove(0, 1);
            respJsonStr = respJsonStr.Remove(respJsonStr.Length - 1);
            var responseAppS = JObject.Parse(respJsonStr);
            string status = responseAppS.Value<string>("Status");
            if (status == "success")
            {
                isCheck = Convert.ToBoolean((responseAppS.
                        SelectToken("ResponseStr").ToString()));
                description = JsonConvert.DeserializeObject<string>(responseAppS.
                        SelectToken("Description").ToString());
            }
            else
            {
                isCheck = false;
                description = "Not Network";
            }
        }
    }
}