namespace MauiApp1
{
    using CommunityToolkit.Mvvm.ComponentModel;

    /// <summary>
    ///     <pre>
    ///         ビューモデル
    /// 
    ///         CommunityToolkit.Mvvm パッケージを NuGET でインストールしてほしい
    ///     </pre>
    /// </summary>
    public class MainPageViewModel : ObservableObject
    {
        // - パブリック・プロパティ

        public int Simple30 => 30;

        public int Simple70 => 70;

        public int Simple50
        {
            get
            {
                return 50;
            }
            set
            {
                // Ignored
            }
        }
    }
}
