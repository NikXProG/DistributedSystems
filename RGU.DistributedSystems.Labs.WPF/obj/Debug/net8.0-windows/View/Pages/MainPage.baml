   M S B A M L   `   `   `  ����Z  VRGU.DistributedSystems.Labs.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullg8clr-namespace:RGU.DistributedSystems.Labs.WPF.View.Pages*RGU.DistributedSystems.Labs.WPF.View.Pages  5      e7clr-namespace:RGU.DistributedSystems.Labs.WPF.ViewModel)RGU.DistributedSystems.Labs.WPF.ViewModel  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35I6clr-namespace:System.Windows;assembly=PresentationCoreSystem.Windows 5      e7clr-namespace:RGU.DistributedSystems.Labs.WPF.Converter)RGU.DistributedSystems.Labs.WPF.Converter  5	      u?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls1RGU.DistributedSystems.Labs.WPF.View.UserControls  5
      U QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem 5      �Eclr-namespace:RGU.DistributedSystems.Labs.WPF.View.AttachedProperties7RGU.DistributedSystems.Labs.WPF.View.AttachedProperties  5      9    3RGU.DistributedSystems.Labs.WPF.View.Pages.MainPage   5      \ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jlocal8clr-namespace:RGU.DistributedSystems.Labs.WPF.View.Pages     5      M	viewModel7clr-namespace:RGU.DistributedSystems.Labs.WPF.ViewModel     5      `systemWindowsPresentationCore6clr-namespace:System.Windows;assembly=PresentationCore     5      N
converters7clr-namespace:RGU.DistributedSystems.Labs.WPF.Converter     5	      Tcontrols?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls     5
      ?system,clr-namespace:System;assembly=System.Runtime     5      dattachedPropertiesEclr-namespace:RGU.DistributedSystems.Labs.WPF.View.AttachedProperties     5        N� Title$  MainPage��5       N� 
Background
 ����� � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $1 +../../ResourceDictionaries/ButtonImage.xaml?�6%   6\   �� 5      $0 *../../ResourceDictionaries/ButtonText.xaml?�6%   6[   �� 5      $2 ,../../ResourceDictionaries/ScrollViewer.xaml?�6%   6]   %    5      .��5      �  � ColumnDefinitions 5      �� 5      $��* �6#   6/   �� 5      $��* �6$   60   �� 5      $��* �6$   60    � RowDefinitions 5!      �� 5"      $��* �6    6-   �� 5#      $��* �6    6-   �� 5$      $��* �6    6-   .+�5+      �� $��1��6   $��0��5,         ImageButtonStyle#��[  5-      
������ 
�������C   =RGU.DistributedSystems.Labs.WPF.View.AttachedProperties.Image   ImageSource$= 7https://cdn-icons-png.flaticon.com/256/2504/2504839.png��51         ScaleX$	 0.5Q�52      	   ScaleY$		 0.5Q�53      
   AlignX$
 Center=�54         AlignY$ Bottom=�55      
   Url$ https://telegram.org/��56      D   >RGU.DistributedSystems.Labs.WPF.View.AttachedProperties.Border   RadiusCoefficient$	 1.0Q�57       � FocusVisualStyle 50      Z� 57      �� 5:      $��1��6   $��1��5;      #��[  5<      
������ $� �https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/VK_Compact_Logo_%282021-present%29.svg/800px-VK_Compact_Logo_%282021-present%29.svg.png��5?      $	 0.5Q�5@      $		 0.5Q�5A      $
 Center=�5B      $ Center=�5C      $ https://telegram.org/��5D      $	 1.0Q�5E         ScaleMaskCoefficient$	 1.0Q�5F         OverlayMask$
 True��5G       5>      Z� 5G      �� 5J      $��0��6   $��0��5K        CustomButtonStyle#��[ 5L      
�������
���   �   CornerRadius$
 30.0��5O      
���   �$��2q�5Q      $��Medium"�5R      .��5S      какая-то хуйня5U      N   HRGU.DistributedSystems.Labs.WPF.View.UserControls.TextBoxNumericKeyboard  5i      $��0��62   $��2��6?      KeyPaddingKeyboard$ 30,15q�5j   2      ColumnSpacingKeyboard$ 0q�5k   2      RowSpacingKeyboard$ 0q�5l   2   $��Bottom=�5n   2      	TextValue 5m   2   �� *TextNumericKeyboardValue+ �� Mode$ TwoWay=�5n   2   �� 5r      $��2��6   $��1��6/   $��Visible=�6<   $
��Auto=�5s      .��5t      �� .+�5v      �� $��0��6!   $��0��5w   !   #��[ 5x   !   
�������
���   �$��20(�5{   !   .��5|   "   Нажми на меня5~      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��20(�5�   !   .��6/   Нажми на меня5�      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��20(�5�   !   .��6/   Нажми на меня5�      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��20(�5�   !   .��6/   Нажми на меня5�      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��20(�5�   !   .��6/   Нажми на меня5�      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��40(�5�   !   .��6/   Нажми на меня5�      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��40(�5�   !   .��6/   Нажми на меня5�      �� 5�      $��0��6!   $��0��5�   !   #��[ 5�   !   
�������
���   �$��40(�5�   !   .��6/   Нажми на меня5�      5�      5�      E   ?RGU.DistributedSystems.Labs.WPF.View.UserControls.SpinnerDialog  5�      $��0��6)   $��1��69   D   >RGU.DistributedSystems.Labs.WPF.View.UserControls.WidgetDialog  5�      $��0��5�      $��2��5�         ButtonCommand 5�      �� *ButtonClickCommand+$ OneWay=�M   GRGU.DistributedSystems.Labs.WPF.View.UserControls.TextBoxLetterKeyboard  5�      $��Bottom=�5�      $��1��5�      $��2��5�      $��2��5�         KeyboardVisible$
 True��5�         ColumnSpacingKeyboard$	 0,8q�5�         RowSpacingKeyboard$	 4,0q�5�         KeyPaddingKeyboard$ 10,12q�5�         BackgroundKeyKeyboard
 �����   ForegroundKeyKeyboard
 �   �   FontSizeKeyKeyboard$ 22Q�5�         	TextValue 5�      �� *TextLetterKeyboardValue+$ TwoWay=�5�      5�      5�      