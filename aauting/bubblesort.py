def bubblesort(arr: list):
    swapped = False
    for i in range(len(arr)-1):
        comp1, comp2 = ord(arr[i]) if isinstance(arr[i], str) else arr[i], ord(arr[i+1]) if isinstance(arr[i+1], str) else arr[i+1]
        if comp1 > comp2:
            arr[i], arr[i+1] = arr[i+1], arr[i]
            swapped = True
    if swapped:
        return bubblesort(arr)
    return arr

test = ["E", "A", "F", "B", "G"]
print(bubblesort(test))

