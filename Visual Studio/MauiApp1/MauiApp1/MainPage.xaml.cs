namespace MauiApp1;

public partial class MainPage : ContentPage
{
	// - その他

	/// <summary>
	///		生成
	/// </summary>
	public MainPage()
	{
		InitializeComponent();
	}

    // - パブリック・プロパティ

	/// <summary>
	///		バインディング・コンテキストを公開する
	/// </summary>
    public MainPageViewModel MainPageVM => this.BindingContext as MainPageViewModel;

}

