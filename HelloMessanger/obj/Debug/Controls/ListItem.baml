   M S B A M L   `   `   `  ����I  EHelloMessanger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:HelloMessangerHelloMessanger  5      N JHelloMessanger.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullV>clr-namespace:HelloMessanger.Core;assembly=HelloMessanger.CoreHelloMessanger.Core 5      !    HelloMessanger.ChatListItem   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:HelloMessanger     5      Ocore>clr-namespace:HelloMessanger.Core;assembly=HelloMessanger.Core     5        � 	Resources  5
         ContentStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name �Name � ColumnDefinitions �� 	Converter5   /HelloMessanger.BooleanToVisibiltyValueConvertor	 �� ConverterParameter
 �� Padding.   (HelloMessanger.StringRGBToBrushConverter �� RelativeSource �� CornerRadius  WhiteForegroundBrush  FontSizeLarge  AccentBrush  
RobotoThin �� Triggers �� Value �� Binding �� 
TargetName  LighterUIElementBrush :� RoutedEvent  DarkerUIElement	 �� To �� TargetProperty �� 
TargetName g� Duration P� Property P� Value  DisabledColorBrush��%�  &	        7  7  7  7  7  7  7  7  �� 5   
   " ��6%   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $ 
background��6!   ._�5      � $ 	container��6#   
������  5   "   �� 5   &   $
��auto �67   6F   �� 5   &   $��* �67   6C   .+�5   "   �� 
����  �$��4��5   !   $
��Left=�5   !   y�5   !   �� *NewMessageAvailable+   $
	 true���� 5   "   $��0��6)   $
 8q�69   ._�5    &   �� ��6-   �� *ProfilePictureRGB+   ��5!   )   �� *ActualHeight+ �� *Self+ 5"   )   �� *ActualHeight+ �� *Self+._�5$   *   �� $��Center=�5%   0   $��Center=�5&   0   8��  8�� ��5$   4   �� *
Initials+5+   +   5,   '   5-   #   �� 5/   "   $��1��6)   $
 8q�69   ._�50   &   �� $��Center=�61   .+�51   *   �� 8�� $��CharacterEllipsis=�53   0   ��51   4   �� *Name+53   0   �� 54   *   8�� $��CharacterEllipsis=�56   0   8�� ��54   4   �� *	Message+57   0   58   '   59   #   5:      5;       5<      �� 5=      $
 true��6I    6*   �� *
IsSelected+.a�5>   "   �� $ 
background��6?   8   � ��6�   5?      :� 5@      $ 
MouseEnter��6+   .[�5A   "   �� .��5B   &   �� .��5C   *   �� 8  $ Background.Color�6_   $ 	container��6�   $ 0:0:0.3D�6�   6�   5D   '   5E   #   5F      :� 5G      $ 
MouseLeave��6+   .[�5H   "   �� .��5I   &   �� .��5J   *   �� $ TransparentX�69   $ Background.Color�6J   $ 	container��6w   $ 0:0:0.3D�6�   6�   5K   '   5L   #   5M      P� 5N       � {� .  . �5O   "   �� $ 	container��6?   8   � ��6V   5P      5R      5T      5U      5V      .��5W      �� #��[  6V   5Y      5[      