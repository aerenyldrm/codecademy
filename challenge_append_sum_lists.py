def append_sum(my_list):
    for counter in range(3):
        my_list.append(my_list[-1] + my_list[-2])
    return my_list

print(append_sum([1, 1, 2]))