   M S B A M L   `   `   `  ����B  >Weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WeatherWeather  5   	       Weather.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Weather     5   	     � Title$  Pogoda_v1.0��5   	   $	��450��6   $��820.2��6*   ��5	      �� 5
   
    �� ImageSource$ weather._no_copyright.jpg��6    �� Opacity$	 0.6Q�6=   .��5      � $��0,0,0.4,-78.2q�6   $	��399��6"   $	��Top=�6/    � ColumnDefinitions 5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ txtEnteredCityName��5      $
��Left=�6.   $��60��6I   $��
61,102,0,0q�6U    �� TextWrapping$
 Wrap=�6i   $	��Top=�6}   $	��437��6�   $��Comic Sans MS)�6�   $��22(�6�   $
��Bold"�6�   ���	#FFFAFAFA �� 
CaretBrush
 �����
�������$��Center=�6  $��Center=�6<  .��6}   J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5      $
 White��6#   $ 1Q�61   5      .��5   #   ��5      �� 5      .��5   "   5      �� 5   
   -   5         ��Name$ Przycisk��5      $�� ��6#   $
��Left=�6.   $��60��6I   $��560,102,0,0q�6U   $	��Top=�6j   $	��207��6�   ��5      �� 5       $ 	enter.png��6    5"      �� 5#      $ 	enter.png��6   5%      �� 5&   
   -   5         ��Name$ lblWeatherDescription��5&      $�� ��6/   $��Center=�6:   $	��204��6W   $��
31,185,0,0q�6d   $	��Top=�6x   $	��736��6�   $��Comic Sans MS)�6�   $��20(�6�   $
��Bold"�6�   
�������$��Center=�6�   �� 5'   
   -   5        $ lblEnterCityName��5'      $(��"Wpisz nazwe miasta i kliknij enter��6*   $��Right=�6W   $��66��6s   $��0,31,140.8,0q�6   $	��Top=�6�   $��Comic Sans MS)�6�   $��36(�6�   $
��Bold"�6�   $	��615��6�   ���	#FFFFF3F3
 �����
�������$��Center=�63  5)      5*      