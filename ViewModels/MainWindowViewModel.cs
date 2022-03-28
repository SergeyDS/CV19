using CV19.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV19.ViewModels
{
    internal class MainWindowViewModel:ViewModel
    {
        private string _Title="Анализ статистики CV19";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title,value);
        }

        private string _Status = "Система готова !";

        public string Status 
        { 
          get => _Status; 
          set => Set(ref _Status, value);
        }
    }
}
