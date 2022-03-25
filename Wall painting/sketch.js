let circleX = 300
let circleY = 120
let xSpeed = 8;
let ySpeed = 8;

let p1Pos = 300;
let p2Pos = 300;

let p1Score = 0;
let p2Score = 0;

let circleSize = 60;

document.addEventListener('keydown', function(e) {
    switch (e.keyCode) {
        case 38:
			// up
			if (p2Pos > 0){
				p2Pos -= 10;
			}
            break;
        case 40:
			// down
			if (p2Pos+200 < height){
				p2Pos += 10;
			}
            break;
        case 87:
			// w
			if (p1Pos > 0){
				p1Pos -= 10;
			}
            break;
        case 83:
			// s
			if (p1Pos+200 < height){
				p1Pos += 10;
			}
            break;
    }
});

function setup(){
    createCanvas(windowWidth, windowHeight);
}


function draw(){
    background(0);

    stroke(255);
    strokeWeight(4);
    // line(2, 2, width, 2)
    // line(2, height-2, width, height-2);
	
    // line(2, 2, 2, height-2);
    // line(width-2, 2, width-2, height-2);
	ellipse(circleX, circleY, circleSize);

	circleX += xSpeed;
	circleY += ySpeed;

	if (((circleX + circleSize/2 >= width-50) && p2Pos <= circleY && circleY <= p2Pos + 200)){
		xSpeed = -xSpeed;
		circleSize += 1
	}

	if (((circleX - circleSize/2 <= 80) && p1Pos <= circleY && circleY <= p1Pos + 200)){
		xSpeed = -xSpeed;
		circleSize += 1
	}

	if (circleY + circleSize/2 >= height || circleY - circleSize/2 <= 0){
		ySpeed = -ySpeed;
		circleSize += 1
	}



	if (circleX > width){
		p1Score += 1
		circleX = 300
		circleY = 120
		xSpeed = 8;
		ySpeed = 8;
	}

	if (circleX < 0){
		p2Score += 1
		circleX = 300
		circleY = 120
		xSpeed = 8;
		ySpeed = 8;
	}

	textSize(32)
	text(p1Score, width/2-50, 50)
	text(p2Score, width/2+50, 50)

	rect(50, p1Pos, 30, 200)
	rect(width-50, p2Pos, 30, 200)
}
