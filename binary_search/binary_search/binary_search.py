# ввод размера массива и отлов ошибки типа данных 
try:
    N = int(input('Input the size of array:'))
except ValueError:
    print('Error! Invalid type')
array = []
n = 1

# заполнение массива и отлов ошибки типа данных  
for i in range(N):
    try:
       array.append(int(input()))
    except ValueError:
       print('Error! Indalid type')
    ++i                     
    
    
# сортировка массива
while n < N:
     for i in range(N - n):
          if array[i] > array[i+1]:
               array[i], array[i+1] = array[i+1], array[i]
     n += 1


print(array)

# ввод "ключа" и отлов ошибки типа данных
try:
   key = int(input('Input the key:'))
except ValueError:
   print('Error! Invalid type')




# нижний (начальный) индекс
low = 0
# верхний (конечный) индекс
high = N-1
# как только нижний индекс станет больше на 1 верхнего 
# или верхний на 1 меньше нижнего цикл остановится
while low <= high:
    # находится индекс середины массива или отрезка массива
    mid = (low + high) // 2
    # Если искомое число меньше числа с индексом середины,
    if key < array[mid]:
        # то верхняя граница сдвигается к середине 
        high = mid - 1
    # Если искомое число больше числа с индексом середины,
    elif key > array[mid]:
        # то нижняя граница сдвигается за середину
        low = mid + 1
    else:
        print("ID =", mid)
        # прерывание цикла
        break
# в массиве нет искомого числа. 
else:
    print("No the number")

