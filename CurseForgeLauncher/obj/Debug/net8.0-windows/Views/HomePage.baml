   M S B A M L   `   `   `  ����M  ICurseForgeLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CurseForgeLauncher.ViewsCurseForgeLauncher.Views  5      C&clr-namespace:CurseForgeLauncher.UtilsCurseForgeLauncher.Utils  5      '    !CurseForgeLauncher.Views.HomePage   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:CurseForgeLauncher.Views     5      8Utils&clr-namespace:CurseForgeLauncher.Utils     5      -   5        $
��Home��5	   7     � 	Resources  5
      4  .CurseForgeLauncher.Utils.StringToBoolConvertor   StringToBoolConvertor��%   &	          5   
   6F   5      .��5      � $
��Left=�6   $	��Top=�6&   .+�5   
   �� $��Choose a Game��6   $	��Top=�6(   $
��Left=�6@   $��20(�6[   
�������$��	25,15,0,0q�6|   �� 5   
   -   5         ��Name$ 	GamePanel��5      $��Disabled=�6_   $��	15,70,0,0q�6�   ��6%   �� *GameBanners+��6I   Z� ��6�   Z� ��5      �� 5      .R�5      �  K� IsItemsHost$
 True��6    5      ��5      �� 5      .R�5      � $��10,0,0,0q�6    � RowDefinitions 5      �� 5      $��6* �6,   6:   �� 5      6.   �� 5      6.   .+�5"      �� $	��235��6!   $	��175��6.   $
��Left=�6:   ��6\   Z� ��6s   �� *SelectedCommand+��5#      �� 5$   "    �� 
TargetType" ��6(   .�5%   &   ��  �� Property � �� �� Value 5&   *   �� 5'   .    j� Stretch$
 Fill=�69    �� ImageSource 6H   �� *
BannerPath+5)   '   �� 5*   &    � �� 5+   *   �� 5,   .   	 �� 
TargetType"	 ��6>   .R�5-   2   �� #��z��69   ._�5.   6   �� $��Center=�6G   $��Center=�6d   5/   3   50   /   52   '   
 �� Triggers
 53   &   P� 54   *    P� Property �@J�IsMouseOver P� Value$
 True��6I   55   +   57   #   59      �� 5;      $��1��6    
�������$��16(�6Z   ��6-   �� *Title+6j   �� 5<      $��2��6    
�������$��16(�6�   ��6-   �� *IsInstalled+ �� UpdateSourceTrigger$ PropertyChanged=� �� 	Converter# [  6�   5=      5>      5@      5B      5C      