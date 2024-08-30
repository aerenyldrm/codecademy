def larger_sum(list_1, list_2):
    if sum(list_1) >= sum(list_2): return list_1
    else: return list_2

print(larger_sum([1, 9, 5], [2, 3, 7]))