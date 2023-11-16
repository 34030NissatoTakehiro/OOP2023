using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleUnitConverter {
   public class MainWindowViewWeghitModel:ViewModel {
        private double gramValue, pondValu;

        public double GramValue {
            get { return this.gramValue; }
            set {
                this.gramValue = value;
                this.OnPropertyChanged();
            }
        }
        public double PondValue {
            get { return this.pondValu; }
            set {
                this.pondValu = value;
                this.OnPropertyChanged();
            }
        }

        //上のComboBoxで選択されている値（単位）
        public WeightgramUnit CurrentWeightgramUnit { get; set; }

        //下のComboBoxで選択されている値（単位）
        public WeightpondUnit CurrentWeightpondUnit { get; set; }

        //▲ボタンで呼ばれるコマンド
        public ICommand WeightgramUnit { get; private set; }

        //▼ボタンで呼ばれるコマンド
        public ICommand WeightpondUnit { get; private set; }

        //コンストラクタ
        public MainWindowViewWeghitModel() {
            this.CurrentWeightgramUnit = SampleUnitConverter.WeightgramUnit.Units.First();
            this.CurrentWeightpondUnit = SampleUnitConverter.WeightpondUnit.Units.First();

            this.WeightpondUnit = new DelegateCommand(
                () => this.PondValue = this.CurrentWeightpondUnit.FromWeightgramUnit(
                    this.CurrentWeightgramUnit, this.GramValue));

            this.WeightgramUnit = new DelegateCommand(
                () => this.GramValue = this.CurrentWeightgramUnit.FromWeightpondUnit(
                    this.CurrentWeightpondUnit, this.PondValue));

        }
    }
}
