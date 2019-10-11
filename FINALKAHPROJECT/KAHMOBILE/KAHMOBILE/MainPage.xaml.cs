﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace KAHMOBILE
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Comic();
        }

        public async void Comic()
        {
            using(var httpClient = new HttpClient()){
                var response = await httpClient.GetStringAsync("https://127.0.0.1:44360/api/comic");
                var comic = JsonConvert.DeserializeObject<List<Comic>>(response);
                comicList.ItemsSource = comic;
            }
        }
    }
}
