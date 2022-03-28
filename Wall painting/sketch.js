var heights = []

function setup(){
    createCanvas(500, 500);
    background(0);


	let row = []
	for (let i = 0; i < 6; i++){
		for (let j = 0; j<5; j++){
			row[j] = i*2+50-j*10;
		}
		console.log(row)
		heights[i] = row;
	}
}


function draw(){
	for (let i = 0; i < heights.length; i++){
		for (let j = 0; j < 5; j++){
			j = j - 5
			if (j<=0){
				j = 70;
			}
			heights[i][j] = j;
		}
	}
	console.log(heights)
	for (let i = 0; i < 6; i++){
		for (let j = 0; j<5; j++){
			start = 95*i - heights[i][j]
			rect(17+j*100, start, 70, heights[i][j]);
		}
	}
}
