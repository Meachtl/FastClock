   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.3.0.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   R NEventsDemo.FastClockWpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:EventsDemo.FastClockWpfEventsDemo.FastClockWpf 5   	   (   "EventsDemo.FastClockWpf.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   7local%clr-namespace:EventsDemo.FastClockWpf     5   	   -   5          � WindowStyle$  ThreeDBorderWindow=�5	   	   $��2q�6*   #��� ��5
   	    � Title$ FastClock Configurator��5   	   $��234.473��6(   $��595.41��69    � 
ResizeMode$ NoResize=�6H   $��Arial)�5   	    � 	Resources 5      2  ,EventsDemo.FastClockWpf.StringToIntConverter   StringToIntConverter��%   &	          5   
   6%   5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Beschleunigungsfaktor:��6   $��0��61   $��0��6>   $��5q�6N   $��Arial)�6Y   $��16(�6l   �� 5   
   $��
Startzeit:��6   $��1��6%   $��0��63   $��5q�6C   $��Arial)�6N   $��16(�6a   �� 5   
   $��Datum:��6   $��2��6!   $��0��6/   $��Arial)�6?   $��16(�6R   �� 5!   
   -   5         ��Name$ TextBoxFactor��5!      $��0��6)   $��1��66    �� TextWrapping$
 Wrap=�6F   $��60��6Z   $��5q�6d   $��Right=�6o   $��27��6�   $��Bottom=�6�   $	��150��6�   $��Arial)�6�   $��16(�6�   �� 5"   
   -   5         ��Name$ SliderFactor��5"      $��0��6'   $��2��64   $��5q�6D   	 � Minimum$	 1Q�6O   
 � Maximum$
 60000Q�6[    � Value 6k   �� *Text+ �� 	Converter# [   �� ElementName$ TextBoxFactor���� 5#   
   $��1��6   $��1��6%    �� Orientation$ 
Horizontal=�62   .+�5$      (  "System.Windows.Controls.DatePicker  -   5          Name$ DatePickerDate��5$      $��Arial)�61   $��16(�6D   $	��136��6R   $��5q�6^   $��Center=�6i   $��Center=�6�   �� 5%      -   5        $ TextBoxTime��5%      $
 Wrap=�6+   $��00:00��6?   $��99��6L   $��Center=�6W   $��Center=�6t   $��Center=�6�   $��5q�6�   $��Arial)�6�   $��16(�6�   $��5q�6�   5&      �� 5'   
   -   5         ��Name$ TextBlockDate��5'      $��2��6+   $��1��68   $
��Wrap=�6H   $��
01.01.2000��6\   $��Center=�6o   $��Center=�6�   $��Arial)�6�   $��16(�6�   �� 5(   
   -   5        $ TextBlockTime��5(      $��3��6+   $��1��68   $
��Wrap=�6H   $��00:00��6\   $��Segoe UI Black)�6i   $��22(�6�   $��Center=�6�   $��5q�6�   �� 5)   
   -   5         ��Name$ CheckBoxClockRuns��5)      $��Running��6.   $��2��6@   $��2��6P   $��5q�6]   $��Center=�6h   $��16(�6�   6�   �� 5*   
   -	   5         ��Name$ ButtonCreateView��5*      $��Create View��6+   $��2��6A   $��4��6Q   $��5q�6^   $��Arial)�6i   $��16(�6|   6�   �� 5+   
   -
   5        $ ButtonSetTime��5+      $��Set Time��6(   $��2��6;   $��1��6K   $
��5,10q�6X   6f   5,      5-      