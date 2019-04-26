using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPFLearningProject.Views;
using WPFLearningProject.ViewModels;

namespace WPFLearningProject {
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application {

        //アプリケーション起動時に実行される OnStartupメソッドをオーバーライドする。
        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);

            var window = new MainView();
            var viewModel = new MainViewModel();

            //ウィンドウに対するViewModel　をデータコンテキストに指定？
            //何を言っているのかよくわからない…
            window.DataContext = viewModel;

            window.Show();
        }

    }
}
