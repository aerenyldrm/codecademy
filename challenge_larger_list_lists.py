def larger_list(my_list_1, my_list_2):
    if len(my_list_1) >= len(my_list_2): return my_list_1[-1]
    else: return my_list_2[-1]

print(larger_list([4, 10, 2, 5], [-10, 2, 5, 10]))