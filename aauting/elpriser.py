import requests
import json
url = "https://api.adlab.dk/api/prices?period=yesterday"
data = requests.get(url).json()
data = data["Records"]
clean_data = []

for point in data:
    if point["PriceArea"] == "DK1":
        clean_data.append(point)


def find_cheapest_consecutive(hour_count: int, price_data: dict):
    cheapest_price = -1
    cheapest_time = -1
    for i in range(len(price_data) - hour_count):
        current_range = price_data[i:i+hour_count]
        current_price = sum([i["SpotPriceDKK"] for i in current_range])

        if current_price < cheapest_price or cheapest_price == -1:
            cheapest_price = current_price
            cheapest_time = i

    return cheapest_price, cheapest_time


if __name__ == "__main__":
    cheapest_price, cheapest_time = find_cheapest_consecutive(2, clean_data)
    cheapest_time = clean_data[cheapest_time]["HourDK"]
    print(f"Cheapest time : {cheapest_time}\nCheapest price: {cheapest_price}")
