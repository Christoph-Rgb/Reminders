   M S B A M L   `   `   `  ����N  JReminders.WpfClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Reminders.WpfClientReminders.WpfClient  5      O,clr-namespace:Reminders.WpfClient.SampleDataReminders.WpfClient.SampleData  5      ,    &Reminders.WpfClient.CreateReminderView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Reminders.WpfClient     5      ;sd,clr-namespace:Reminders.WpfClient.SampleData     5      $	��325��5	      $	��400��6   .��5      �   � ColumnDefinitions  5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��2��6   $��Create New Reminder��6$      H1LabelStyle#���   6B   �� 5   
   $��1��6   $��Text:��6     CreateReminderLabelStyle#���  6-   �� 5    
   $��1��6   $��1��6     CreateReminderTextBoxStyle#���  6g   $��Stretch=�6�   ��6/   ��  �� Path$ CreatedReminder.Text� �� Mode$ TwoWay=�6�   �� 5"   
   $��2��6   $��	Due Date:��6   #���  61   (  "System.Windows.Controls.DatePicker  5#   
   $��2��6   $��1��6"    ! CreateReminderDatePickerStyle#���  6u   $��Stretch=�6�      SelectedDate 62   �� $ CreatedReminder.DueDate�$ TwoWay=�6�   �� 5%   
   $��3��6   $��Alarm Date:��6   #���  63     5&   
   $��3��6   $��1��6"   #���  6w   $��Stretch=�6�    62   �� $ CreatedReminder.AlarmDate�$ TwoWay=�6�   �� 5(   
   $��4��6   $��	Category:��6   #���  61   �� 5)   
   $��4��6   $��1��6     �� DisplayMemberPath$
 Name��6X   $��5q�6�   ��60   �� $ 
Categories� �� SelectedItem 6q   �� $ CreatedReminder.Category�$ OneWayToSource=�6�   �� 5+   
   $��5��6   $��Notes:��6   #���  6.   �� 5,   
   $��5��6   $��1��6   #���  6h   $��Stretch=�6�   ��6/   �� $ CreatedReminder.Notes�$ TwoWay=�6�   �� 5.   
   $��6��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��Right=�6O   $��Bottom=�6k   $��5q�6�   .+�5/      �� -   5        $
��25px��5/      $
��75px��6#   $��0 0 5 0q�60   $��Cancel��6A   6R   �� 50      -   5        $
��25px��50      $
��75px��6#   $��5 0 0 0q�60   $
��Save��6A   6P   51      52      53      