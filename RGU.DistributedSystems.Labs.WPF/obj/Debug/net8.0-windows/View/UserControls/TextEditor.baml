   M S B A M L   `   `   `  ����Z  VRGU.DistributedSystems.Labs.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullu?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls1RGU.DistributedSystems.Labs.WPF.View.UserControls  5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity 5      k:clr-namespace:RGU.DistributedSystems.Labs.WPF.Presentation,RGU.DistributedSystems.Labs.WPF.Presentation  5      �Eclr-namespace:RGU.DistributedSystems.Labs.WPF.View.AttachedProperties7RGU.DistributedSystems.Labs.WPF.View.AttachedProperties  5
      B    <RGU.DistributedSystems.Labs.WPF.View.UserControls.TextEditor   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Qlocal?clr-namespace:RGU.DistributedSystems.Labs.WPF.View.UserControls     5      ^iPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity     5      Spresentation:clr-namespace:RGU.DistributedSystems.Labs.WPF.Presentation     5      A =Stylet, Version=1.3.7.0, Culture=neutral, PublicKeyToken=null)s!https://github.com/canton7/Stylet  5	      ^attachedPropertiesEclr-namespace:RGU.DistributedSystems.Labs.WPF.View.AttachedProperties  5
        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $2 ,../../ResourceDictionaries/ScrollViewer.xaml?�6%   6]   %    5      .��5      �� $
��Auto=�6   $
��Auto=�5      $
��true��5   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
�������
������ $��0q�5&      
���   �$��Stretch=�5+      $��Stretch=�5,      $��Hidden=�50      $��Center=�51      $��Hidden=�52       �� SelectedIndex 5       �� *SelectedIndex+ �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType local:TextEditor �� UpdateSourceTrigger$ PropertyChanged=�	 �� Mode$	 TwoWay=���5'      �� *
FontSize+ �� $ FindAncestor=� local:TextEditor$	 TwoWay=���5-      �� 
 �� Path$
 Items� �� $ FindAncestor=�B   <RGU.DistributedSystems.Labs.WPF.View.UserControls.TextEditor"  ��55      �� 56      .R�57      �� .+�58      �� ��59      �� 5:      5;      ��5=      �� 5>       �� 
TargetType" ��6   .�5?      ��  �� Property � �� �� Value$ 0q�6/   6;   �� 5@       � ��$ 0q�60   6<   �� 5A       � �� 5B      �� 5C       �� 
TargetType" ��6.   .R�5D   "   � .+�5E   *   �� $
��Mask��61    J� Opacity$ 0Q�5F   1   
���   �5H   +   � 5I   *    5J   -   �� 5K   1   $��25 �6B   6O   �� 5L   1   $��* �6B   6O   �� 5M   1   $��25 �6B   6O   .+�5P   *   �� $��1��61   $��Right=�5Q   1   $��0q�5R   1   ._�5S   .   �� 5T   +   5V   *   5W   #    �� Triggers 5X   "   P� 5Y   &    P� Property �@��
IsSelected P� Value$
 True��6D   . �5Z   *   ��  �� 
TargetName$
 Mask��61    �@J�Opacity$	 0.1Q�6V   �� 5[   *    � ��
 �   �6G   5\   '   5^      5`      5a      5c      �� 5e   
   $��0q�5f      $��1��5g      " �� VerticalScrollBarVisibility$ Hidden=�5h      $ �� HorizontalScrollBarVisibility$ Hidden=�5i       �� AcceptsReturn$
 True��5j      
���������5k      �� *
FontSize+ �� $ FindAncestor=� local:TextEditor$	 OneWay=���5o      �� $
 TextContent�$	 TwoWay=�$ PropertyChanged=� �� *FindAncestor+ local:TextEditor.��5s      ��5t      �� 5u      " ��6"   .R�5v      � .+�5w      ��  ��Name$ MainEditorTextBox��5x      #��z��5y      # z 5z      # z 5{      # z 5|      #��z��5}      #��z��5�      ��5~      �� $

 Text� �� *TemplatedParent+$	 TwoWay=�$ PropertyChanged=�.��5�      .  (System.Windows.Interactivity.Interaction   Triggers 5�      /  )System.Windows.Interactivity.EventTrigger  5�   "      	EventName$ SelectionChanged��61   .  (System.Windows.Interactivity.TriggerBase   Actions. 5�   &   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6<   �� *SelectedChangedCommand+   CommandParameter 5�   <   ��  �� *FindAncestor+ TextBox5�   #     5�   "   $ TextChanged��61   . 5�   &      6<   �� *TextChangedCommand+5�   #   .��5�   6   5�      �� 5�       J� IsHitTestVisible$ False��6$   
���������5�   $   �� $.
 ((attachedProperties:TextBox.PlaceHolder)� ��  local:TextEditor$ FindAncestor=���5�      �� 5�   "   " ��6(   .�5�   &   ��  � y�$ 	Collapsed=�6C    �� Triggers 5�   &   �� 5�   *    �� Binding 66   �� *Text+  �� ElementName$  MainEditorTextBox��! �� Value!  5�   I   .a�5�   .   ��  � y�$ Visible=�6K   5�   +   5�   #   5�      5�      5�      .��5�        5�        5�      $ 
MouseWheel��6!   . 5�      N   HRGU.DistributedSystems.Labs.WPF.Presentation.InvokeDelegateCommandAction  "   Command" 5�      �� *FontSizeChangedCommand+#   CommandParameter# 5�      ��  �� *Self+$
 InvokeParameter�5�      .��5�   &   5�      5�      5�      5�      