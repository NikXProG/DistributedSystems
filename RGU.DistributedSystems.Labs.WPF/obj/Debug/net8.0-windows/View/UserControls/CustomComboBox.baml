   M S B A M L   `   `   `  ����Z  VRGU.DistributedSystems.Labs.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls1RGU.DistributedSystems.Labs.WPF.View.UserControls  5      F    @RGU.DistributedSystems.Labs.WPF.View.UserControls.CustomComboBox   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls     5        � 	Resources  5	         WindowColor  ContentAreaColorLight  ContentAreaColorDark  DisabledControlLightColor  DisabledControlDarkColor  DisabledForegroundColor  SelectedBackgroundColor  SelectedUnfocusedColor  ControlLightColor 	 ControlMediumColor 
 ControlDarkColor  ControlMouseOverColor  ControlPressedColor  
GlyphColor  GlyphMouseOver  BorderLightColor  BorderMediumColor  BorderDarkColor  PressedBorderLightColor  PressedBorderDarkColor  DisabledBorderLightColor  DisabledBorderDarkColor  DefaultBorderBrushDarkColor  HeaderTopColor " DatagridCurrentCellBorderColor  SliderTrackDarkColor  NavButtonFrameColor  MenuPopupBrush �� EndPoint �� 
StartPoint � Color � Offset $  ProgressBarIndicatorAnimatedFill  ComboBoxToggleButton �� 
TargetType � ColumnDefinitions'  !System.Windows.VisualStateManager   VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState	   
Storyboard
 �� TargetProperty �� 
TargetName8  2System.Windows.Media.Animation.EasingColorKeyFrame �� KeyTime �� Value ��Name �� CornerRadius �� Color F�Name  ComboBoxTextBox �� 
TargetType �� Property �� Value R� KeyTime  System.Windows.Visibility   Visible R� Value   Hidden d�Name �� 	ClickMode d� 	IsChecked �� Mode �� RelativeSource ��Name J� IsHitTestVisible  �� SelectionBoxItem! �� SelectionBoxItemTemplate" ��Name# �� 
IsReadOnly$ �� 
IsReadOnly% �Name& �� IsDropDownOpen' � AllowsTransparency( �Name) J� SnapsToDevicePixels* � ActualWidth+ �� MaxDropDownHeight, K� IsItemsHost-  'System.Windows.Input.KeyboardNavigation-   DirectionalNavigation. �� Triggers/ P� Property0 P� Value1 �� 
TargetName2 P� 
SourceName3 �� Padding��%�  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	     &		 %    &	
 F    &	 g    &	 �    &	 �    &	 �    &	     &	 .    &	 O    &	 p    &	 �    &	 �    &	 �    &	 �    &	     &	 2    &	 O    &	 p    &	 �    &	 X    &	 �    7  7  7  7  7  &	 %    '�� �    7  7  7  '�� �    7  7  ��5
      	#FFE8EDF9��61   ��5      	#FFC5CBF9��67   ��5      	#FF7381F9��66   ��5      	#FFE8EDF9��6;   ��5      	#FFC5CBF9��6:   ��5      	#FF888888��69   ��5      	#FFC5CBF9��69   ��5      	#FFDDDDDD��68   ��5      	White��6/   ��5      	#FF7381F9��64   ��5      	#FF211AA9��62   ��5      	#FF3843C4��67   ��5      	#FF211AA9��65   ��5      	#FF444444��6,   ��5      /+sc#1, 0.004391443, 0.002428215, 0.242281124��6R   ��5!      	#FFCCCCCC��62   ��5"      	#FF888888��63   ��5#      	#FF444444��61   ��5%      	#FF888888��69   ��5&      	#FF444444��68   ��5(      	#FFAAAAAA��6:   ��5)      	#FF888888��69   ��5+      	Black��69   ��5.      	#FFC5CBF9��60   ��5/      	Black��6<   ��50      	#FFC5CBF9��66   ��52      	#FF3843C4��65   �� 54      $ 0.5,1&�55      $ 0.5,0&�56      .��57   
   � # �  6   $ 0Q�58      � 59   
   # � 	 6   $	 0.5Q�5:      � 5;   
   # �  6   $ 1Q�5<      5=   	   �� 5?      $	 0,0&�5@      $	 1,0&�5A      ��5C      � � 5D      $ 	#000000FF��6   $ 0Q�5E      � 5F      $ 	#600000FF��6   $	 0.4Q�5G      � 5H      $ 	#600000FF��6   $	 0.6Q�5I      � 5J      $ 	#000000FF��6   $ 1Q�5K      5L      5N   	   �� 5O      " d�5P      .R�5Q      �  5R      �� 5S      �� 5T      $��20 �6!    5V        5W      CommonStates��. 5X        
Normal��6     5Y      	MouseOver��.	 5Z      �� .��5[      �� $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�63   $ Border��5]   3   .g�5^        $ 0��6,   8   5_   ,   5`      5a      5b        5c      Pressed��6     5d      Disabled��.	 5e      �� .��5f      �� $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�63   $ Border��5h   3   .g�5i        $ 0��6,   8  5j   ,   5k      �� 5l      $C
 =(Shape.Fill).                         (SolidColorBrush.Color)�63   $ Arrow��5n   3   .g�5o        $ 0��6,   8  5p   ,   5q      �� 5r      $i
 c(Border.BorderBrush).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�63   $ Border��5t   3   .g�5u        $ 0��6,   8  5v   ,   5w      5x      5y      5z        5{      CheckStates��. 5|        Checked��.	 5}      �� .��5~      �� $g
 a(Panel.Background).                         (GradientBrush.GradientStops)[1].(GradientStop.Color)�63   $ Border��5�   3   .g�5�        $ 0��6,   8  5�   ,   5�      5�      5�        5�      	Unchecked��6     5�      Indeterminate��6   5�      .+�5�      �� $ Border��6   $��2��5�      $ 2��5�      $��1q�5�      ��5�      �� 5�      $	 0,1&�6&   $	 0,0&�5�   &   .��5�      � # �  6!   $ 0Q�5�   !   � 5�      # �  6!   $ 1Q�5�   !   5�      ��5�      �� 5�      $	 0,0&�6&   $	 0,1&�5�   &   ��5�      � � 5�      # �  6%   � 5�      # � 	 6%   $	 1.0Q�5�   %   5�      5�      5�      �� 5�      $��0��6   $ 2,0,0,2��5�      $��1q�5�      ��5�      �� 5�      # �  6$   5�      F� 5�      $ Arrow��6   $��1��5�      $��Center=�5�      $��Center=�5�      "����        � 	=  	= � z     	��5�      �� 5�      # �  6$   5�      5�      5�      �� 5�   
   " ��5�      .R�5�      �� $ PART_ContentHost��6   $|�False��5�      #��z��5�      5�      �� 5�   
   " ��5�      .�5�      ��  �@J�SnapsToDevicePixels$
 true��5�      �� 5�       �@�OverridesDefaultStyle$
 true��5�      �� 5�       � ��$
 Auto=�5�      �� 5�       � ��$
 Auto=�5�      �� 5�       � ��$
 true��5�      �� 5�       � ��$	 120��5�      �� 5�       � ��$ 20��5�      �� 5�       � �� 5�      �� 5�      " ��6    .R�5�      �  5�        5�      CommonStates��. 5�        
Normal��6$     5�      	MouseOver��6$     5�      Disabled��.	 5�      �� .��5�      �� $ PART_EditableTextBox��69   $U
 O(TextElement.Foreground).                               (SolidColorBrush.Color)�5�   9   .g�5�        $ 0��62   8   5�   2   5�      5�      5�      5�        5�      
EditStates��. 5�        Editable��.	 5�      �� .��5�      T� $
 (UIElement.Visibility)�6:   $ PART_EditableTextBox��5�   :   ..�5�      i� $ 0��65   # Z 5�   5   5�      T� 5�      $
 (UIElement.Visibility)�5�      $ ContentSite��5�   :   ..�5�      i� $ 0��65   # Z 5�   5   5�      5�      5�        5�      
Uneditable��6$   5�      .+�5�      d� $ ToggleButton��6!   8�� $��2��5�   !   $|�false��5�   !   $ Press=�5�   !    5�   !   �� *IsDropDownOpen+$ TwoWay=� �� *TemplatedParent+�� 5�      $ ContentSite��6%   $ False��5�   %   #��z  5�   %   #��z! 5   %   #��z��5  %   $��3,3,23,3q�5  %   $��Stretch=�5  %   $
��Left=�5  %   5     �� 5     $" PART_EditableTextBox��6   8�� $
��Left=�5	     $��Bottom=�5
     $��3,3,23,3q�5     $
|�True��5     
������ $y�Hidden=�5     #$ z# 5     ��5     Z� 5     � 5     $% Popup��6   $��Bottom=�5     #��z& 5     $
' True��5     $|�False��5     $��Slide=�5     .��5     � $( DropDown��6   $
) True��5     #��z* 5     #��z+ 5     .+�5     �� $ DropDownBorder��6   $��1q�5     ��5     �� 5     # �  6,   ��5     �� 5      # �  6,   5"     �� 5#     $��4,6,4,6q�6%   $
) True��5$  %   .��5%     �� $
, True��6%   $- 	Contained=�5&  %   5'     5(     5)     5*     . 5+     P� 5,     / �@��HasItems$0 false��5-     . �5.     �� $1 DropDownBorder��6    � ��$ 95��50     51     P� 52     / �@��
IsGrouping$
0 true��53     . �54     ��  � ��$ false��55     56     P� 57     $2 Popup��6   / �@�AllowsTransparency$
0 true��59     . �5:     �� $1 DropDownBorder��6    �@��CornerRadius$ 4��5<     �� 5=     $1 DropDownBorder��6    � ��$ 0,2,0,0q�5?     5@     5B     5D     5E     �� 5G  
   " ��5H     .�5I     ��  �@J�SnapsToDevicePixels$
 true��5J     �� 5K      �@�OverridesDefaultStyle$
 true��5L     �� 5M      � �� 5N     �� 5O     " ��6    .R�5P     �� $ Border��6   $3 2q�5Q     $
) true��5R     
������  5T       5U     SelectionStates��. 5V       
Unselected��6$     5W     Selected��.	 5X     �� .��5Y     �� $ Border��69   $M
 G(Panel.Background).                             (SolidColorBrush.Color)�5Z  9   .g�5\       $ 0��62   8   5]  2   5^     5_     5`       5a     SelectedUnfocused��.	 5b     �� .��5c     �� $ Border��69   $M
 G(Panel.Background).                             (SolidColorBrush.Color)�5d  9   .g�5f       $ 0��62   8  5g  2   5h     5i     5j     5k     ._�5m     �� 5n     5o     5q     5r     5t     .��5u     � .+�5v  
   �� 5x     5y     5z     