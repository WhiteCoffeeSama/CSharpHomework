using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

/*
*向李沛昊同学学习了一下，基本每一句都明白了
*/

namespace PracticeCmd
{
    public class Crawler
    {
        //列表urlss
        private Queue<string> urlss = new Queue<string>();
        //哈希表urls
        private Hashtable urls = new Hashtable();
        //count = 0;
        private int count = 0;
        //字符串html
        private string html;

        static void Main(string[] args)
        {
            //startUrl网址
            string startUrl = "http://www.hao123.com/";

            //假设Main中args[]不为空
            if (args.Length >= 1)
                startUrl = args[0];

            //爬虫对象
            Crawler myCrawler = new Crawler(startUrl);

            myCrawler.Crawl();

            ////哈希表增加startUrl，值为false
            //myCrawler.urls.Add(startUrl, false);

            ////线程开始
            //new Thread(myCrawler.Crawl).Start();

            //并行编程

            Console.ReadLine();
        }

        public Crawler(string url)                      //构造函数
        {
            //初始化字符串html
            html = "";
            //如果url长度不为0，进队
            if (url.Length > 0)
                urlss.Enqueue(url);
        }

        private void Crawl()                            //爬行函数
        {
            Console.WriteLine("开始爬行...");
            while (true)
            {
                //队列中无元素
                if (urlss.Count == 0)
                    continue;

                //临时字符串（列队）
                string currents = urlss.Peek();

                //最多10个网页，结束
                if (currents == null || count > 10)
                    break;

                Console.WriteLine("爬行" + currents + "页面!");

                //获得html文件
                DownLoad(currents);

                Thread thread = new Thread(Parse);
                thread.Start();

                //获取超链接
                //Parse(html);
            }

            Console.WriteLine("爬行结束！");

            //while(true)
            //{
            //    //临时字符串（哈希表）
            //    string current = null;
            //    //在 哈希表urls 中的Keys中
            //    foreach (string url in urls.Keys)
            //    {
            //        //如果哈希表urls中这个Key对应的Value时True，继续
            //        if ((bool)urls[url])
            //            continue;
            //        //临时字符串等于哈希表中的这个Key值
            //        current = url;
            //    }

            //    //如果临时字符串为空，或count > 10
            //    if (current == null || count > 10)
            //        break;

            //    Console.WriteLine("爬行" + current + "页面!");

            //    //字符串html = DownLoad(current)
            //    //生成html文件
            //    string html = DownLoad(current);

            //    //哈希表中该Key值对应的Value为True
            //    urls[current] = true;
            //    //count++
            //    count++;

            //    //Parse(html)
            //    Parse(html);
            //}
        }

        public void DownLoad(string url)                //下载html文件
        {
            try
            {
                //创建WebClient对象webClient
                WebClient webClient = new WebClient();
                //webClient对象Encoding为UTF.8
                webClient.Encoding = Encoding.UTF8;
                //字符串html为webClient.DownloadString(url)
                string html = webClient.DownloadString(url);
                //文件地址名称为fileName
                string fileName = count.ToString() + ".html";
                //队头，出队，count++
                urlss.Dequeue();
                count++;
                //生成文件
                File.WriteAllText(fileName, html, Encoding.UTF8);
                //重置字符串html
                lock (this.html)
                    this.html = html;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                urlss.Dequeue();
            }
        }

        public void Parse()                             //加载超链接
        {
            lock (this.html)
            {
                //正则表达式strRef
                string strRef = @"(href|HREF)[ ]*=[ ]*[""'][^""'#(img)]+[""']";
                //string strRef = @"(href|HREF)[]*[""'][^""'#>]+[""']";

                //Match集合，判断 .html 中有多少个超链接，生成matches
                MatchCollection matches = new Regex(strRef).Matches(html);
                //对每一个match进行：
                foreach (Match match in matches)
                {
                    //获取超级链接
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\\', '#', ' ', '>');
                    //strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');

                    //如果超链接为空，continue
                    if (strRef.Length == 0)
                        continue;

                    //超链接入队
                    urlss.Enqueue(strRef);

                    //if (urls[strRef] == null)
                    //    urls[strRef] = false;
                }
            }
        }
    }
}