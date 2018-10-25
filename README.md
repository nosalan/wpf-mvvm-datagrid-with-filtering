# WPF MVVM Datagrid with Filtering
An example of WPF Datagrid with Filtering capability and expandable headers. Coded in MVVM style.

The filtering control is placed inside of the header of the column being filtered (in the image below it is *Name* column). The filter is collapsed by default, user needs to expand the expander in the column header to apply filtering. When filter is applied to the grid, the textbox with filter term is highlighted in red. 

![alt text](http://1.bp.blogspot.com/-dBgqfkyXzk8/Ukx5XYaiDbI/AAAAAAAAAGE/mNpYWjc6qk0/s1600/2-wpf-mvvm-filtering-1.png)

The filtering is performed directly on the collection bound to the *Datagrid*. A collection that supports filtering natively is *CollectionViewSource*, in this case this collection is wrapped around the *ObservableCollection*. When filter is active it also applies to newly added elements. 
