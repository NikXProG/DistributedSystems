   M S B A M L   `   `   `  ����Z  VRGU.DistributedSystems.Labs.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls1RGU.DistributedSystems.Labs.WPF.View.UserControls  5      >    8RGU.DistributedSystems.Labs.WPF.View.UserControls.DdMenu   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls     5        � 	Resources  5	       �� MergedDictionaries �� Source   placeHolder �� 
TargetType �� BasedOn �� Property �� Value �� 
TargetType ��Name	 K� ZIndex
 �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding �� Source%  System.Windows.Markup.Reference �� Value�� 5
   
    5      �� 5      $0 *../../ResourceDictionaries/ButtonText.xaml?�6%   6[   %z  &	        7���� 5      " ��6(   8   .�5      ��  � �� 5      �� 5      " ��6*   .R�5      � .+�5   "   �� $ 
textSource��5   *   
������ $	 2��5   *   ��5   *   �� $

 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5   *   �� 5   "   #��z 6*   #��z��6G   $	 1��6q   .��6�   ��5   &   �� 5   *   " ��60   .�5   .   ��  � ��
 ���� 6K    5   .   �� 5    2    6>   �� $

 Text�   *
textSource+  6}   .a�5!   6   ��  � ��
 �����6S   5"   3   5$   +   .��5%   5   5&   #   5'      5(      5*      5+      5,      .��5.      �  � ColumnDefinitions 5/   	   �� 50      $��* �6   6)   �� 51      $
��Auto �6   6-   �� 52      $
��Auto �6   6-   .+�54   
   �� #��[  55      $��25(�56      $ example: 1,5,7��57      $��0��58      6   �� 59   
   $��1��6   $��20(�6#   $��Light"�5:      $��Roboto)�5;       �� SelectedIndex$ 0��5<      $��Center=�5=      ��5?      �� 5@      .R�5A      �� .+�5B      �� ��6$   �� �� 5C      ��6$   ��  ��  �� Mode$ TemplatedParent=�$
 	ItemIndex�5D      5E      @�5G      �� 5H      $4��.состояние всех регистров��5I       � ToolTip$� �вывести состояние всех регистров в системе счисления, которая записана в 1 операнде��5J      6u   �� 5K      $� �поразрядная инверсия над содержимом 1 операнда, результат сохраняется в 3 операнд��5L      $-��'поразрядная инверсия��5M      66   �� 5N      $z tдизъюнкция над 1 и 2 операндом, результат сохраняется в 3 операнд��5O      $��дизъюнкция��5P      6,   �� 5Q      $� �сложение по модулю 2 над 1 и 2 операндом, результат сохраняется в 3 операнд��5R      $��конъюнкция��5S      6,   �� 5T      $(��"сложение по модулю��6   6>   �� 5U      $��импликация��6   66   �� 5V      $��коимпликация��6   68   �� 5W      $��эквиваленция��6   68   �� 5X      $��стрелка Пирса��6   69   �� 5Y      $��штрих Шеффера��6   69   �� 5Z      $��сложение��6   64   �� 5[      $��вычитание��6   65   5]      �� 5^   
     CustomButtonStyle#��[ 5_      $��2��5`      ���#2078F9
����������#236FE0$��2q�5d      $��20(�5e      $
��20,0q�5f      .��5g      
сompile5j      5k      5l      