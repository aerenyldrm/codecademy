def more_frequent_item(my_list, item_1, item_2):
    if my_list.count(item_1) >= my_list.count(item_2): return item_1
    else: return item_2  

print(more_frequent_item([2, 3, 3, 2, 3, 2, 3, 2, 3], 2, 3))