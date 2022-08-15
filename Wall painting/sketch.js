function setup(){
	createCanvas(500, 500);
	background(220);
	// Center gridlines
	line(width/2, 0, width/2, height);
	line(0, height/2, width, height/2);
	// Borders
	stroke(0, 128, 255);
	strokeWeight(4);
	line(2, 2, width, 2)
	line(2, height-2, width, height-2);
	line(2, 2, 2, height-2);
	line(width-2, 2, width-2, height-2);
}

function draw(){
	// Hortizontal lines
	stroke(0, 128, 255);
	strokeWeight(4);
	line(20, 30, 200, 30);
	line(20, 150, 200, 150);

	// Vertical lines
	for(let i = 1; i<=10; i++){
		line(20*i, 30, 20*i, 150);
	}

	// Circles
	noStroke();
	fill(255, 128, 0);
	let circleGrid = 5;  // Size of circle grid
	for(let i=0; i<circleGrid; i++){
		for(let j=0; j<circleGrid; j++){
			if (i%2==0){
				circle(40+i*40, 280+j*40, 20);
			}
			else{
				circle(40+i*40, 300+j*40, 20);
			}
		}
	}

	// Squares
	stroke(0, 128, 255);
	let squareGrid = 5;  // Size of square grid
	for(let i=0; i<squareGrid; i++){
		for(let j=0; j<squareGrid; j++){
			if (i%2==0){
				square(280+i*40, 20+j*40, 20);
			}
			else{
				square(280+i*40, 45+j*40, 20);
			}
		}
	}

	// Diagonal lines
	stroke(255, 0, 255);
	strokeWeight(2);
	for(let i=0; i<5; i++){
		line(350-i*20, 300+i*20, 450-20*i, 400+20*i);
	}
}
