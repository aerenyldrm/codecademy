def reversed_list(list_1, list_2):
    check_boolean = True
    for counter in range(len(list_1)):
        if list_1[counter] != list_2[(counter + 1) * - 1]: check_boolean = False
    return check_boolean

print(reversed_list([1, 2, 3], [3, 2, 1]))
print(reversed_list([1, 5, 3], [3, 2, 1]))