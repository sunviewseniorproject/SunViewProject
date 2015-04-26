using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Added Namespaces
using System.Diagnostics;
using System.Net;
using System.Data.SqlClient;
using System.IO;
using System.Web;
using System.Net.Cache;
using System.Net.NetworkInformation;

namespace SunViewProject1
{
    public partial class Form1 : Form
    {

        bool timeThresholdFlag = false; 

        string httpServerStaticHtmlPage = "http://10.226.37.46:8080/Default.aspx";
        string getRequestAppServer = "http://10.226.37.46:8080/DynamicPage.aspx";

        public Form1()
        {
            InitializeComponent();
        }

        private void httpServerRTButton_Click(object sender, EventArgs e)
        {
            //Put while loop here
            for (int iTimes = 0; iTimes < 1; iTimes++)
            {
                ProcessStaticHTTPGetData();

                if (timeThresholdFlag)
                {
                    for (int iTimes2 = 0; iTimes2 < 10; iTimes2++)
                    {
                        ProcessStaticHTTPGetData();
                    }
                    timeThresholdFlag = false;
                }
            }
        }

        public void ProcessStaticHTTPGetData()
        {
            Stopwatch timer = new Stopwatch();
            double avgResponseTime = 0.00;
            string tsDifference = "";

            string tsRequest = DateTime.Now.ToString("F");
            DateTime ts_request = DateTime.Now;
            tsRequestHttpServerLabel.Text = tsRequest;

            // Send Request to HTTP Server
            timer.Start();
            RequestCachePolicy policy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
            WebRequest webRequest = HttpWebRequest.Create(httpServerStaticHtmlPage);
            webRequest.CachePolicy = policy;
            HttpWebResponse httpResponse = (HttpWebResponse)webRequest.GetResponse();
            timer.Stop();

            string tsResponse = DateTime.Now.ToString("F");
            DateTime ts_response = DateTime.Now;
            TimeSpan span = ts_response.Subtract(ts_request);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                TimeSpan timeTaken = timer.Elapsed;
                avgResponseTime = timeTaken.TotalMilliseconds;

                tsResponseHttpServerLabel.Text = tsResponse;
                responseTimeHttpServerLabel.Text = avgResponseTime.ToString("f2") + " ms";
                tsDifference = span.TotalMilliseconds.ToString();
            }

            httpResponse.Close();

            // Create connection string to database
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sqlQuery = null;

            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\SunViewProject1\SunViewProject1\Servers.mdf;Integrated Security=True";
            sqlQuery = "INSERT into ServersDB (ResponseTime, TSRequest, TSResponse, TypeOfServer, TSDifference) VALUES (@ResponseTime, @TSRequest, @TSResponse, @TypeOfServer, @TSDifference)";
            cnn = new SqlConnection(connectionString);

            string httpServer = "HTTP Server";

            try
            {
                cnn.Open();
                command = new SqlCommand(sqlQuery, cnn);
                command.Parameters.AddWithValue("@ResponseTime", avgResponseTime.ToString("f2"));
                command.Parameters.AddWithValue("@TSRequest", tsRequest);
                command.Parameters.AddWithValue("@TSResponse", tsResponse);
                command.Parameters.AddWithValue("@TypeOfServer", httpServer);
                command.Parameters.AddWithValue("@TSDifference", tsDifference);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkLogsButton_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }

        //Read data from URL File
        public void readData(string server)
        {

            //used to build entire input
            StringBuilder sb = new StringBuilder();

            //used on each read operation
            byte[] buf = new byte[8192];

            //prepare the web page we will be asking for
            RequestCachePolicy policy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
            HttpWebRequest request = (HttpWebRequest)
            WebRequest.Create(server);
            request.CachePolicy = policy;

            //execute the request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //we will read data via the response stream
            Stream resStream = response.GetResponseStream();

            string tempString = null;
            int count = 0;

            do
            {
                //fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);

                //make sure we read some data
                if (count != 0)
                {
                    //translate from bytes to ASCII text
                    tempString = Encoding.ASCII.GetString(buf, 0, count);

                    //continue building the string
                    sb.Append(tempString);
                }
            }
            while (count > 0); // any more data to read?

            //print out page source
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText(@"H:\SunViewProject1\urlData.html");

                outputFile.WriteLine(sb);
                outputFile.Close();
            }
            catch (Exception ex)
            {
                // Display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void readDataButton_Click(object sender, EventArgs e)
        {
            readData(httpServerStaticHtmlPage);
            Process.Start(httpServerStaticHtmlPage);
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        //GET Application Server
        private void getRequestAppServerRTButton_Click(object sender, EventArgs e)
        {
            //Put while loop here
            for (int iTimes = 0; iTimes < 1; iTimes++)
            {
                ProcessGetRequestAppServerData();
                //System.Threading.Thread.Sleep(1000);
            }
        }

        private void getRequestReadDataAppServerButton_Click(object sender, EventArgs e)
        {
            readData(getRequestAppServer);
            Process.Start(getRequestAppServer);
        }

        public void ProcessGetRequestAppServerData()
        {
            Stopwatch timer = new Stopwatch();
            double avgResponseTime = 0.00;
            string tsDifference = "";

            string tsRequest = DateTime.Now.ToString("F");
            DateTime ts_request = DateTime.Now;
            getRequestTsRequestAppServerLabel.Text = tsRequest;

            // Send Request to HTTP Server
            timer.Start();
            RequestCachePolicy policy = new RequestCachePolicy(RequestCacheLevel.BypassCache);
            WebRequest webRequest = HttpWebRequest.Create(getRequestAppServer);
            webRequest.CachePolicy = policy;
            HttpWebResponse httpResponse = (HttpWebResponse)webRequest.GetResponse();
            timer.Stop();

            string tsResponse = DateTime.Now.ToString("F");
            DateTime ts_response = DateTime.Now;
            TimeSpan span = ts_response.Subtract(ts_request);

            if (httpResponse.StatusCode == HttpStatusCode.OK)
            {
                TimeSpan timeTaken = timer.Elapsed;
                avgResponseTime = timeTaken.TotalMilliseconds;

                getRequestTsResponseAppServerLabel.Text = tsResponse;
                getRequestResponseTimeAppServerLabel.Text = avgResponseTime.ToString("f2") + " ms";
                tsDifference = span.TotalMilliseconds.ToString();
            }

            httpResponse.Close();

            // Create connection string to database
            string connectionString = null;
            SqlConnection cnn;
            SqlCommand command;
            string sqlQuery = null;

            connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\SunViewProject1\SunViewProject1\Servers.mdf;Integrated Security=True";
            sqlQuery = "INSERT into ServersDB (ResponseTime, TSRequest, TSResponse, TypeOfServer, TSDifference) VALUES (@ResponseTime, @TSRequest, @TSResponse, @TypeOfServer, @TSDifference)";
            cnn = new SqlConnection(connectionString);

            string appServer = "App Server Get Request";

            try
            {
                cnn.Open();
                command = new SqlCommand(sqlQuery, cnn);
                command.Parameters.AddWithValue("@ResponseTime", avgResponseTime.ToString("f2"));
                command.Parameters.AddWithValue("@TSRequest", tsRequest);
                command.Parameters.AddWithValue("@TSResponse", tsResponse);
                command.Parameters.AddWithValue("@TypeOfServer", appServer);
                command.Parameters.AddWithValue("@TSDifference", tsDifference);
                command.ExecuteNonQuery();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Ping --> Get Request Static --> Get Request Dynamic --> Ping
        private void pingButton_Click(object sender, EventArgs e)
        {
            for (int iTimes = 1; iTimes <= 1; iTimes++)
            {
                //Ping object 
                Ping pingSender1 = new Ping();

                // Determine whether a remote computer is accessible over the network.
                PingReply reply1 = pingSender1.Send("10.226.37.46");

                if (reply1.Status == IPStatus.Success)
                {
                    // Get roundtrip time
                    ping1Label.Text = "Ping 1 roundtrip time: " + reply1.RoundtripTime.ToString() + " ms";
                }
                else
                {
                    MessageBox.Show(reply1.Status.ToString());
                }

                // Get Request to Static HTML Page in HTTP Server
                // The Stopwatch class assists the manipulation of timing-related 
                // performance counters within managed code
                Stopwatch timerStatic = new Stopwatch();
                double avgResponseTimeStatic = 0.00;
                string tsDifferenceStatic = "";

                // Timestamp before the server requests are sent
                string tsRequestStatic = DateTime.Now.ToString("F");
                DateTime ts_requestStatic = DateTime.Now;
                tsRequestHttpServerLabel.Text = tsRequestStatic;

                // Start begins counting at the cumulative elapsed time
                timerStatic.Start();

                // No entries are taken from caches, added to caches, or removed from caches between the client and server
                RequestCachePolicy policyStatic = new RequestCachePolicy(RequestCacheLevel.BypassCache);

                // Send Request to HTTP Server
                WebRequest webRequestStatic = HttpWebRequest.Create(httpServerStaticHtmlPage);
                webRequestStatic.CachePolicy = policyStatic;

                // Get response back from HTTP server
                HttpWebResponse httpResponseStatic = (HttpWebResponse)webRequestStatic.GetResponse();

                // Stop ends the current interval measurement and freezes 
                // the cumulative elapsed time value
                timerStatic.Stop();

                string tsResponseStatic = DateTime.Now.ToString("F");
                DateTime ts_responseStatic = DateTime.Now;
                TimeSpan spanStatic = ts_responseStatic.Subtract(ts_requestStatic);


                double staticResponse = 0.00;
                if (httpResponseStatic.StatusCode == HttpStatusCode.OK)
                {
                    // Get the elapsed time as a TimeSpan value
                    TimeSpan timeTakenStatic = timerStatic.Elapsed;
                    avgResponseTimeStatic = timeTakenStatic.TotalMilliseconds;

                    tsResponseHttpServerLabel.Text = tsResponseStatic;
                    responseTimeHttpServerLabel.Text = avgResponseTimeStatic.ToString("f2") + " ms";
                    tsDifferenceStatic = spanStatic.TotalMilliseconds.ToString();

                    // Response time minus Ping 1
                    staticResponse = avgResponseTimeStatic - reply1.RoundtripTime;
                }

                // Release the connection for reuse
                httpResponseStatic.Close();

                // Get Request to Dynamic HTML Page in Application Server
                // The Stopwatch class assists the manipulation of timing-related 
                // performance counters within managed code
                Stopwatch timerDyn = new Stopwatch();
                double avgResponseTimeDyn = 0.00;
                string tsDifferenceDyn = "";

                // Timestamp before the server requests are sent
                string tsRequestDyn = DateTime.Now.ToString("F");
                DateTime ts_requestDyn = DateTime.Now;
                getRequestTsRequestAppServerLabel.Text = tsRequestDyn;

                // Start begins counting at the cumulative elapsed time
                timerDyn.Start();

                // No entries are taken from caches, added to caches, or removed from caches between the client and server
                RequestCachePolicy policyDyn = new RequestCachePolicy(RequestCacheLevel.BypassCache);

                // Send Request to App Server
                WebRequest webRequestDyn = HttpWebRequest.Create(getRequestAppServer);
                webRequestDyn.CachePolicy = policyDyn;

                // Get response back from Application server
                HttpWebResponse httpResponseDyn = (HttpWebResponse)webRequestDyn.GetResponse();

                // Stop ends the current interval measurement and freezes 
                // the cumulative elapsed time value
                timerDyn.Stop();

                string tsResponseDyn = DateTime.Now.ToString("F");
                DateTime ts_responseDyn = DateTime.Now;
                TimeSpan spanDyn = ts_responseDyn.Subtract(ts_requestDyn);


                double dynamicResponse = 0.00;
                if (httpResponseDyn.StatusCode == HttpStatusCode.OK)
                {
                    // Get the elapsed time as a TimeSpan value
                    TimeSpan timeTakenDyn = timerDyn.Elapsed;
                    avgResponseTimeDyn = timeTakenDyn.TotalMilliseconds;

                    getRequestTsResponseAppServerLabel.Text = tsResponseDyn;
                    getRequestResponseTimeAppServerLabel.Text = avgResponseTimeDyn.ToString("f2") + " ms";
                    tsDifferenceDyn = spanDyn.TotalMilliseconds.ToString();

                    // Response time minus Ping 1
                    dynamicResponse = avgResponseTimeDyn - reply1.RoundtripTime;
                }

                // Release the connection for reuse
                httpResponseDyn.Close();


                //Ping Server
                Ping pingSender2 = new Ping();

                // determine whether a remote computer is accessible over the network.
                PingReply reply2 = pingSender2.Send("10.226.37.46");

                if (reply2.Status == IPStatus.Success)
                {
                    // Get roundtrip time
                    ping2Label.Text = "Ping 2 roundtrip time: " + reply2.RoundtripTime.ToString() + " ms";
                }
                else
                {
                    MessageBox.Show(reply2.Status.ToString());
                }

                // Check for time threshold violations. If more than 500 ms, run multiple tests
                // to provide further information on if this was a singular glitch (false positive), 
                // or a continual error
                if (avgResponseTimeStatic > 500.00)
                {
                    for (int iTimes2 = 0; iTimes2 < 10; iTimes2++)
                    {
                        // Get Request to Static HTML page in HTTP server
                        ProcessStaticHTTPGetData();
                    }
                }

                // Check for time threshold violations. If more than 500 ms, run multiple tests
                // to provide further information on if this was a singular glitch (false positive), 
                // or a continual error
                if (avgResponseTimeDyn > 500.00)
                {
                    for (int iTimes2 = 0; iTimes2 < 10; iTimes2++)
                    {
                        // Get Request to Dynamic HTML page in App server
                        ProcessGetRequestAppServerData();   
                    }
                }

                // Create connection string to database
                string connectionString = null;
                SqlConnection cnn;
                SqlCommand command;
                string sqlQuery = null;

                connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=H:\SunViewProject1\SunViewProject1\PingGet.mdf;Integrated Security=True";
                sqlQuery = "INSERT into PingGetTable (Ping1, GetStatic, GetDynamic, Ping2, NetStaticRT, NetDynRT) VALUES (@Ping1, @GetStatic, @GetDynamic, @Ping2, @NetStaticRT, @NetDynRT)";
                cnn = new SqlConnection(connectionString);

                try
                {
                    cnn.Open();
                    command = new SqlCommand(sqlQuery, cnn);
                    command.Parameters.AddWithValue("@Ping1", reply1.RoundtripTime.ToString());
                    command.Parameters.AddWithValue("@GetStatic", avgResponseTimeStatic.ToString("f2"));
                    command.Parameters.AddWithValue("@GetDynamic", avgResponseTimeDyn.ToString("f2"));
                    command.Parameters.AddWithValue("@Ping2", reply2.RoundtripTime.ToString());
                    command.Parameters.AddWithValue("@NetStaticRT", staticResponse.ToString("f2"));
                    command.Parameters.AddWithValue("@NetDynRT", dynamicResponse.ToString("f2"));
                    command.ExecuteNonQuery();
                    cnn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //print out page source
                try
                {
                    StreamWriter outputFile1, outputFile2, outputFile3, outputFile4;
                    outputFile1 = File.AppendText(@"H:\SunViewProject1\pingTest1.csv");
                    outputFile2 = File.AppendText(@"H:\SunViewProject1\getStaticTest.csv");
                    outputFile3 = File.AppendText(@"H:\SunViewProject1\getDynamicTest.csv");
                    outputFile4 = File.AppendText(@"H:\SunViewProject1\pingTest2.csv");
                    outputFile1.WriteLine("Ping Roundtrip: " + reply1.RoundtripTime.ToString() + " ms");
                    outputFile2.WriteLine("Response Time Get Static: " + avgResponseTimeStatic.ToString("f2") + " ms");
                    outputFile3.WriteLine("Response Time Get Dynamic: " + avgResponseTimeDyn.ToString("f2") + " ms");
                    outputFile4.WriteLine("Ping Roundtrip: " + reply2.RoundtripTime.ToString() + " ms");
                    outputFile1.Close();
                    outputFile2.Close();
                    outputFile3.Close();
                    outputFile4.Close();
                }
                catch (Exception ex)
                {
                    // Display error message
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void pingLogsButton_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
