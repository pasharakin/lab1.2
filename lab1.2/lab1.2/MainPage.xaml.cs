﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab1._2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(zn.Text);
            int a = x % 10;
            x = x / 10;
            int b = x % 10;
            x = x / 10;
            int sum = a + b + x;
            rezA.Text = sum.ToString();
            int pro = a * b * x;
            rezB.Text = pro.ToString();
        }
    }
}
