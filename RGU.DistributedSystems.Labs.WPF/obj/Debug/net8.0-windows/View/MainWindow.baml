   M S B A M L   `   `   `  ����Z  VRGU.DistributedSystems.Labs.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls1RGU.DistributedSystems.Labs.WPF.View.UserControls  5   	   5    /RGU.DistributedSystems.Labs.WPF.View.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Tcontrols?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls     5   	   V RMicrosoft.Windows.Shell, Version=3.5.41019.1, Culture=neutral, PublicKeyToken=nullKshell?http://schemas.microsoft.com/winfx/2006/xaml/presentation/shell  5   	   -   5          � Icon$,  &pack://application:,,,/Assets/icon.png��5	   	    � Title$ Я ебал собак��5
   	   $	��800��5   	   $	��830��5   	    � WindowStartupLocation$ CenterScreen=�5   	   
������  � AllowsTransparency$
 True��5   	    � WindowStyle$
 None=�5   	    � 	Resources 5       �� MergedDictionaries �� Source   ButtonStateChangedStyle �� 
TargetType	 �� Property
 �� Value �� 
TargetType ��Name J� Opacity �� Triggers P� Property P� Value �� 
TargetName�� 5   
    5      �� 5      $) #../ResourceDictionaries/Styles.xaml?�6%   %�  &	        �� 5      " ��65   .�5      �� 	 � ��

 ���� 6/   �� 5      	 � ��
 �#5454546/   �� 5      	 � ��$
 
Montserrat)�6/   �� 5      	 � ��$
 16(�6-   �� 5      	 � ��$
 0q�64   �� 5       	 �@�OverridesDefaultStyle$

 True��6:   �� 5!      	 � ��
 5"      �� 5#      " ��6*   .R�5$      � .+�5%   "   �� $ 
MaskBorder��6)   
���   �$ 0Q�6P   6^   �� 5&   "   $ Border��6)   #��z��5'   )   #��z��5(   )   #��z��5)   )   ._�5*   &   �� $��Center=�67   $��Center=�6T   5+   #   5-       5.      P� 5/   "    �@J�IsMouseOver$
 True��6A   . �50   &   �� $ 
MaskBorder��6-   	 �@J�Opacity$	
 0.1Q�6X   51   #   53      55      56      58      .��5<      E   ?RGU.DistributedSystems.Labs.WPF.View.UserControls.ClippedBorder  ���#F3F3F3 �� CornerRadius$ 8��5>   	   ���#C8C8C8$��1q�5?   	   ._�5@   
   � 
������  � RowDefinitions 5A      �� 5B      $��30 �6    �� 5C      $
��Auto �6    �� 5D      .+�5F      � $��0��6    � ColumnDefinitions 5G      �� 5H      �� 5I      $��45 �6'   �� 5J      $��45 �6'   �� 5K      $��45 �6'   .+�5N      �� $��0��6    �� Orientation$ 
Horizontal=�5O      $��Center=�5P      .+�5R      �� $��../Assets/icon.png��5S      $��18��5T      $��Center=�5U      $��Center=�5V      $	��5,0q�5W       �� BitmapScalingMode 5X      ,  &System.Windows.Media.BitmapScalingMode 5Y      HighQuality=�6=   5[      �� 5^      $��RGU.WPF.Labs��6    $��Center=�5_       $��Center=�5`       5a      �� 5c      -   5        $��1��5d       � ToolTip$ Свернуть��5e      $��14(�5f      #��[  5g      $��Center=�5i      $��Center=�5j      
������ 
������ ��5o      �� 5p      .R�5q      �� $
��🗕��6(    J� RenderTransformOrigin$ 0.5,0.5&�62   z�5r   "   T� 5s   &    T� Y$ -5Q�69   5u      5v      5x      �� 5y      -   5        $��2��5z      $ Развернуть��5{      $
��🗖��5|      
������ 
������ $��14(�5�      #��[  5�      ��5�      �� 5�      .R�5�      �� $
��🗖��6(   $ 0.5,0.5&�62   z�5�   "   T� 5�   &   $ -2Q�69   5�      5�      5�      �� 5�      -   5        $��0q�5�      $��
Montserrat)�5�      $��3��5�      $	��✕��5�      $��14(�5�      $ Закрыть��5�      ��5�      �� 5�      " ��6    .�5�      �� 	 � ��

 ���� 6;   �� 5�      	 � ��
 �#5454546;   �� 5�      	 � ��$
 
Montserrat)�6;   �� 5�      	 � ��$
 16(�69   �� 5�      	 � ��$
 0q�6@   �� 5�      	 �@�OverridesDefaultStyle$

 True��6F   �� 5�      	 � ��
 5�   "   �� 5�   &   " ��66   .R�5�   *   �� $ Border��61   #��z��5�   1   $ 0,8,0,0��5�   1   #��z��5�   1   #��z��5�   1   ._�5�   .   �� $��Center=�6?   $��Center=�6\   5�   +    5�   *   P� 5�   .    �@J�IsMouseOver$
 True��6M   . �5�   2   �� 	 � ��
 �#FFFFFF6O   �� 5�   2   $ Border��69   	 � ��
 �#C42B1C6c   �� 5�   2   $ Border��69   	 �@��CornerRadius$
 0,8,0,0��6e   5�   /   5�   '   5�      5�      5�      5�      �� 5�      ���#EAEAEA$��1��6-   6<    � 5�      -   5          �Name$ MainWindowMainFrame��5�      $��2��5�        � NavigationUIVisibility$ Hidden=�5�      5�      5�      5�      