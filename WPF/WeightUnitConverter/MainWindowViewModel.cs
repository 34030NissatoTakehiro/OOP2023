using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
    public class MainWindowViewModel : ViewModel{
        private double gramValue, pondValue;

        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChanged();
            }
        }
        public double PondValue {
            get { return this.pondValue; }
            set {
                this.pondValue = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public WeightgramUnit currentgramWeghit { get; set; }

        //下のComboBoxで選択されている値（単位）
        public WeightpondUnit CurrentWeightpondUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand Weightpond{ get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand Weghigram { get; private set; }

        //コンストラクタ
        public MainWindowViewModel() {
            this.currentgramWeghit = WeightgramUnit.Units.First();
            this.CurrentWeightpondUnit = WeightpondUnit.Units.First();

            this.Weghigram = new DelegateCommand(
                () => this.PondValue = this.CurrentWeightpondUnit.FromWeightgramUnit(
                    this.currentgramWeghit, this.GramValue));

            this.Weightpond = new DelegateCommand(
                () => this.GramValue = this.currentgramWeghit.FromWeightpondUnit(
                    this.CurrentWeightpondUnit, this.PondValue));

        }
    }
}
