   M S B A M L   `   `   `  ����G  ChotelBooking, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:hotelBookinghotelBooking  5   	       hotelBooking.Admin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:hotelBooking     5   	     � Title$  Admin��5   	   $	��450��6   $	��800��6$   .��5	      � .+�5
   
   �� -   5        $��Show All Hotels��5
      $
��Left=�6+   $��150,164,0,0q�6F   $	��Top=�6[   $	��459��6s   6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ hotelDataGrid��5      $��150,199,191,104q�6%      CanUserAddRows$
 True��5         AutoGenerateColumns$ False��5      ��5      ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Hotel ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *	hotelID+  5      $ 
Hotel Name��6%    69   �� *	hotelName+  5      $ Hotel Address��6%    6<   �� *hotelAddress+  5      $ 
Hotel City��6%    69   �� *	hotelCity+  5      $ Hotel Ratings��6%    6<   �� *hotelRatings+  5      $ Room Availability��6%    6@   �� *roomAvailability+5      �� 5   
   -   5         ��Name$ txtHotelCitySelector��5      $
��Left=�60   $��319,128,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   $&�� Enter the city for hotel search:��6   $
��Left=�6;   $��150,124,0,0q�6V   $	��Top=�6k   �� 5   
   $��Admin��6   $
��Left=�6    $��	72,44,0,0q�6;   $	��Top=�6N   $��56��6f   $	��222��6r   $��30(�6~   5      5      