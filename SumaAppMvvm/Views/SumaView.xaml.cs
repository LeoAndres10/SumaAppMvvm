using SumaAppMvvm.ViewModel;

namespace SumaAppMvvm.Views;

public partial class SumaView : ContentPage
{
	private SumaViewModel viewModel;
	public SumaView()
	{
		InitializeComponent();
		viewModel = new SumaViewModel();
		BindingContext=viewModel;
	}
}