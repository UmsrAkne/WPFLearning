using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFLearningProject.ViewModels {
    class MainViewModel: INotifyPropertyChanged{

        //大文字に変換して取得
        private string _upperString;
            
        public string UpperString{
            get { return this._upperString; }
            private set {
                if(this._upperString != value) {
                    this._upperString = value;
                    raisePropertyChanged("UpperString");
                }
            }
        }

        //入力文字列の取得、設定
        private string _inputString;

        public string InputSring {
            get { return this._inputString; }
            set {
                if(this._inputString != value) {
                    this._inputString = value;
                    raisePropertyChanged("InputString");

                    this.UpperString = this._inputString.ToUpper();
                    System.Diagnostics.Debug.WriteLine("UppertString = " + this.UpperString);
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void raisePropertyChanged(string propertyName) {
            var h = this.PropertyChanged;
            if (h != null) h(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
