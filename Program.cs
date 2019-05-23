using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValidatedMove
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                Console.WriteLine("請輸入單一Group的ResourceID檔案位置(.txt):");
                Console.WriteLine("***注意token請放在File第一行");
                string FilePath = Console.ReadLine();

                //Pass the file path and file name to the StreamReader constructor
                Console.WriteLine("讀取resourceId file，"+ FilePath);
                //StreamReader sr = new StreamReader("C:\\sample.txt");
                StreamReader sr = new StreamReader(FilePath);

                //Read the first line of text
                line = sr.ReadLine();

                List<string> resourceIdGroup = new List<string>();


                //Continue to read until you reach end of file
                while (line != null)
                {
                    resourceIdGroup.Add(line);
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                Console.WriteLine();
                Console.WriteLine("Resource File input Finish!");


                string Token = resourceIdGroup[0];

                resourceIdGroup.RemoveAt(0);

                //輸入token
                //無法用輸入的拿到token，原因是token太長，Console.ReadLine()無法接收這麼多字元。
                //Console.WriteLine("請輸入Token:");
                //var Token = Console.ReadLine();
                //var Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6IkhCeGw5bUFlNmd4YXZDa2NvT1UyVEhzRE5hMCIsImtpZCI6IkhCeGw5bUFlNmd4YXZDa2NvT1UyVEhzRE5hMCJ9.eyJhdWQiOiJodHRwczovL21hbmFnZW1lbnQuY29yZS53aW5kb3dzLm5ldC8iLCJpc3MiOiJodHRwczovL3N0cy53aW5kb3dzLm5ldC80ZTZiYTQ5Mi1jYzExLTRmNWUtYmZmYS01OWU4NzM2MmUwOWQvIiwiaWF0IjoxNTU3Mzg2MTE4LCJuYmYiOjE1NTczODYxMTgsImV4cCI6MTU1NzM5MDAxOCwiYWNyIjoiMSIsImFpbyI6IkFVUUF1LzhMQUFBQUwrR000SWV1dk84RExVUGNBRE1LMi8zOXo3UUdrSU0wZTYwRGFyb0JsUVN0VG9raHlrcnZiSno3OGxDL1VQM05ZR3lTeE9lM1pYcDR2M2cxejhwajBnPT0iLCJhbHRzZWNpZCI6IjE6bGl2ZS5jb206MDAwNjdGRkVGOEVBNjcwMyIsImFtciI6WyJwd2QiXSwiYXBwaWQiOiI3ZjU5YTc3My0yZWFmLTQyOWMtYTA1OS01MGZjNWJiMjhiNDQiLCJhcHBpZGFjciI6IjIiLCJlbWFpbCI6Inh1eGFrZTZAaG90bWFpbC5jb20iLCJmYW1pbHlfbmFtZSI6Inh1eGFrZSIsImdpdmVuX25hbWUiOiJ4dSIsImlkcCI6ImxpdmUuY29tIiwiaXBhZGRyIjoiMTIyLjE0Ni41Ni4yMzQiLCJuYW1lIjoieHV4YWtlNiIsIm9pZCI6ImRlNzVmZmE3LTI0NDctNDBhNy1hMWRiLTE3YTY1N2JmMDVkNSIsInB1aWQiOiIxMDAzMjAwMDQ2QjdGRjVEIiwic2NwIjoidXNlcl9pbXBlcnNvbmF0aW9uIiwic3ViIjoiOWJ2NzlwRW1WbGZ3Nk1VVndNQS1YeU9qcmVFekZxTDNhbVJtV3UzeFRaWSIsInRpZCI6IjRlNmJhNDkyLWNjMTEtNGY1ZS1iZmZhLTU5ZTg3MzYyZTA5ZCIsInVuaXF1ZV9uYW1lIjoibGl2ZS5jb20jeHV4YWtlNkBob3RtYWlsLmNvbSIsInV0aSI6IlNkSU85d0Z1dkVxS01xMXJUVHZUQUEiLCJ2ZXIiOiIxLjAifQ.blGT0oDIk41Ah-5qv-lhJoIopLyylW0c0oW4ezePXw3l2wcf7_cX1VAziD53TiMzZxi_62gnUTRHR2yN0rRhoSfbjfgmjLGeLTZDudE_vwk0MNR8ru3XlL8SuGk1fUV8amQt1vbp6kOmkNGu3R0_4tFoMaAi9cA5rQyimhc47AldE9-MhIeUJAJFljtqMFd3Hwi_6__jTVZC2nqOrX5-SjZLKi6u3NhS6qPaNtUV63e5MDgky7Ifr4SftrnNQCocrewwsSYP1-lp1ax2FFTh2AwtT4jX0jE2sN6fbNd33bJvQ3Z5jIN7f5fLVmv9fyvr1hq-kHTgjo62DCQbP3K9BQ";

                //輸入subscriptionId
                Console.WriteLine("請輸入原始SubScriptionId:");
                string SubScriptionId = Console.ReadLine();
                //var SubScriptionId = "6827748c-0470-4bec-9e0d-3e0363afe843";

                //輸入sourceGroupName
                Console.WriteLine("請輸入sourceGroupName:");
                string SGN = Console.ReadLine();
                //var SGN = "tzbh";

                //輸入CSP SubScriptionId
                Console.WriteLine("請輸入CSP SubScriptionId:");
                var CSPSubScriptionId = Console.ReadLine();
                //var CSPSubScriptionId = "9b818d91-7f83-47a0-a479-3d418407b443";

                //輸入TargetGroupName
                Console.WriteLine("請輸入TargetGroupName:");
                string TGN = Console.ReadLine();
                //var TGN = "/subscriptions/" + CSPSubScriptionId + "/resourceGroups/" + "tzbh";

                TGN = "/subscriptions/" + CSPSubScriptionId + "/resourceGroups/" + TGN;








                //建立 WebRequest 並指定目標的 uri
                WebRequest request = WebRequest.Create("https://management.azure.com/subscriptions/" + SubScriptionId + "/resourceGroups/" + SGN + "/validateMoveResources?api-version=2018-05-01");
                //指定 request 使用的 http verb
                request.Method = "POST";
                //準備 post 用資料
                PostData postData = new PostData() { resources = resourceIdGroup, targetResourceGroup = TGN };
                //指定 request 的 content type
                //2019/05/03 415 errpr : "application/json;"; 字串內不需要;
                request.ContentType = "application/json";
                //指定 request header
                request.Headers.Add("authorization", "Bearer " + Token);
                //將需 post 的資料內容轉為 stream 
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(postData);
                    streamWriter.Write(json);
                    streamWriter.Flush();
                    //streamWriter.Close();
                }
                //使用 GetResponse 方法將 request 送出，如果不是用 using 包覆，請記得手動 close WebResponse 物件，避免連線持續被佔用而無法送出新的 request
                using (var httpResponse = (HttpWebResponse)request.GetResponse())
                {
                    if (httpResponse.StatusCode == System.Net.HttpStatusCode.Accepted)
                    {
                        string GetURL = httpResponse.Headers["Location"];
                        WebRequest GetRequest = WebRequest.Create(GetURL);
                        GetRequest.Method = "GET";
                        GetRequest.Headers.Add("authorization", "Bearer " + Token);

                        var HttpGetResponse = (HttpWebResponse)GetRequest.GetResponse();
                        var ResponseStatus = HttpGetResponse.StatusCode;
                        int AfterTime = Int32.Parse(HttpGetResponse.Headers["Retry-After"]);


                        HttpGetResponse.Close();
                        //new StreamReader(HttpGetResponse.GetResponseStream()).ReadToEnd();

                        while (ResponseStatus == System.Net.HttpStatusCode.Accepted)
                        {
                            Console.WriteLine("驗證中，請等待 " + AfterTime + "秒後再次確認。");
                            for (int a = AfterTime; a >= 0; a--)
                            {
                                //Console.SetCursorPosition(0, 2);//?
                                //Console.WriteLine("Generating Preview in {0} ", a);  // Override complete previous contents
                                System.Threading.Thread.Sleep(1000);
                            }


                            WebRequest GetRequestAgain = WebRequest.Create(GetURL);
                            GetRequestAgain.Method = "GET";
                            GetRequestAgain.Headers.Add("authorization", "Bearer " + Token);

                            HttpGetResponse = (HttpWebResponse)GetRequestAgain.GetResponse();
                            ResponseStatus = HttpGetResponse.StatusCode;
                            if (ResponseStatus == System.Net.HttpStatusCode.Accepted)
                                AfterTime = Int32.Parse(HttpGetResponse.Headers["Retry-After"]);
                            else if (ResponseStatus == System.Net.HttpStatusCode.NoContent)
                                break;
                            HttpGetResponse.Close();
                        }


                        if (ResponseStatus == System.Net.HttpStatusCode.NoContent)
                        {
                            Console.WriteLine("StatusCode: 204 NoContent.驗證成功!");
                            Console.WriteLine("ResponseHeader :");
                            Console.WriteLine(HttpGetResponse.Headers);
                            HttpGetResponse.Close();
                        }
                        else
                        {
                            Console.WriteLine(HttpGetResponse);
                        }
                    }



                    //使用 GetResponseStream 方法從 server 回應中取得資料，stream 必需被關閉
                    //使用 stream.close 就可以直接關閉 WebResponse 及 stream，但同時使用 using 或是關閉兩者並不會造成錯誤，養成習慣遇到其他情境時就比較不會出錯
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        var result = streamReader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                }


            }

            catch (WebException ex)
            {
                using (var stream = ex.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    string ErrorMessage = reader.ReadToEnd();

                    ErrorData Message = JsonConvert.DeserializeObject<ErrorData>(ErrorMessage);

                    //dynamic message = JsonConvert.DeserializeObject<dynamic>(ErrorMessage);

                    Console.WriteLine("Code:");
                    Console.WriteLine(Message.error.code);
                    Console.WriteLine("Message:");
                    Console.WriteLine(Message.error.message);
                    if (Message.error.details != null)
                    {
                        Console.WriteLine("Detail:");
                        Console.WriteLine(Message.error.details[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
                Console.Read();
            }
        }
    }
}
