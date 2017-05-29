using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Counter
{
    class MainWindowViewModel : ViewModel
    {
        private int count;

        public int Count
        {
            get { return this.count; }
            set {
                this.count = value;
                this.OnPropertyChanged();
            }

        }

        public int PlusOne(int current)
        {
            return ++current;

        }

        public int MinusOne(int current)
        {
            if (current != 0)
            {
                current--;
            }
            return current;
        }

        public ICommand Plus { get; private set; }
        public ICommand Minus { get; private set; }

        public MainWindowViewModel()
        {
            count = 0;
            this.Plus = new DelegateCommand(
                () => Count = PlusOne(Count));
            this.Minus = new DelegateCommand(
                () => Count = MinusOne(Count));
        }
    }
}
