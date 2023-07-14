﻿namespace MauiApp1
{
    using Microsoft.Maui.Graphics;

    internal class SimpleDrawing : BindableObject, IDrawable
    {
        // - パブリック・プロパティ

        #region 束縛可能プロパティ（左）
        /// <summary>
        ///     左
        /// </summary>
        public int Left
        {
            get => (int)GetValue(LeftProperty);
            set => SetValue(LeftProperty, value);
        }

        /// <summary>
        ///     タイル・カーソルの線の半分の太さ
        /// </summary>
        public static BindableProperty LeftProperty = BindableProperty.Create(
            // プロパティ名
            propertyName: nameof(Left),
            // 返却型
            returnType: typeof(int),
            // これを含んでいるクラス
            declaringType: typeof(SimpleDrawing));
        #endregion

        #region 束縛可能プロパティ（左）
        /// <summary>
        ///     上
        /// </summary>
        public int Top
        {
            get => (int)GetValue(TopProperty);
            set => SetValue(TopProperty, value);
        }

        /// <summary>
        ///     タイル・カーソルの線の半分の太さ
        /// </summary>
        public static BindableProperty TopProperty = BindableProperty.Create(
            // プロパティ名
            propertyName: nameof(Top),
            // 返却型
            returnType: typeof(int),
            // これを含んでいるクラス
            declaringType: typeof(SimpleDrawing));
        #endregion

        // - パブリック・メソッド

        #region メソッド（描画）
        /// <summary>
        ///     描画
        /// </summary>
        /// <param name="canvas">描画領域</param>
        /// <param name="dirtyRect">位置とサイズ</param>
        /// <exception cref="NotImplementedException"></exception>
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;

            canvas.DrawLine(
                new Point(),
                new Point(Left, Top));
        }
        #endregion
    }
}
