   M S B A M L   `   `   `  ����	  Sklep&     Sklep.Views.Edytowanie_kategorii   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v21.2, Version=21.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5        � Title$  Edytowanie kategorii��5      $	��504��6"   $	��506��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   �� $��Wybierz kategorię:��6   $
��Left=�6-   $��	10,19,0,0q�6H   $	��Top=�6[   $
��Bold"�6s   �� 5   
   $��Nowa nazwa:��6   $
��Left=�6&   $��	10,58,0,0q�6A   $	��Top=�6T   $
��Bold"�6l   �� 5   
   -   5         ��Name$ Nowa_nazwa_kategorii_Text��5      $
��Left=�65   $��	90,58,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $��TextBox��6w   $	��Top=�6�   $	��120��6�   �� 5   
   -   5         ��Name$  ComboBox_wybierz_kategorie��5      $
��Left=�67   $��
125,19,0,0q�6R   $	��Top=�6f   $	��120��6~    �� DisplayMemberPath$ nazwa_kategorii��6�    �� SelectedItem 6�   �� *id_kategorii+6�   &   DevExpress.Xpf.Core.SimpleButton  5   
   -   5          Name$ Zapisz��5      $��Zapisz��6*   $
��Left=�6;   $��50��6V   $��
326,30,0,0q�6b   $	��Top=�6v   $	��125��6�      Glyph 6�   *  $DevExpress.Xpf.Core.DXImageExtension  *SvgImages/Save/Save.svg+6�   5      5      