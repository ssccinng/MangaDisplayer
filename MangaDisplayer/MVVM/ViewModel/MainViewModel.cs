using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaDisplayer.MVVM.ViewModel
{
    public class MainViewModel: ObservableRecipient
    {
		private string _selectFolder;

		public string SelectFolder
		{
			get { return _selectFolder; }
			set { SetProperty(ref _selectFolder, value); }
		}

	}
}
