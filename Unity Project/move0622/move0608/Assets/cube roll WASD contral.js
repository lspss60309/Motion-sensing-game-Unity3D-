var cubeSize: float = 1;
var cubeSpeed: float = 500;
var UpFace: Transform;
 
private
var totalRotation: float = 0; // determines if we're past the 90 degrees
private
var beRolling: boolean = false;
private
var RotateDir: int;
private
var startRotate: boolean = false;
private
var RotatePivot: Vector3;
private
var NextRot: Vector3;
private
var NextPosi: Vector3;
 
// Use this for initialization
function Start() {
    NextRot = transform.rotation.eulerAngles;
    NextPosi = transform.position;
}
 
// Update is called once per frame
function Update() {
    if (beRolling == false) {
        if (Input.GetKey("left")) {
            if (NextPosi.x > -4) {
                //print("rolling");
                beRolling = true;
                startRotate = true;
                RotateDir = 0;
                NextPosi.x--;
            }
        } else if (Input.GetKey("up")) {
            if (NextPosi.z < 4) {
                //print("rolling");
                beRolling = true;
                startRotate = true;
                RotateDir = 1;
                NextPosi.z++;
            }
        } else if (Input.GetKey("right")) {
            if (NextPosi.x < 4) {
                //print("rolling");
                beRolling = true;
                startRotate = true;
                RotateDir = 2;
                NextPosi.x++;
            }
        } else if (Input.GetKey("down")) {
            if (NextPosi.z > -4) {
                //print("rolling");
                beRolling = true;
                startRotate = true;
                RotateDir = 3;
                NextPosi.z--;
            }
        }
    } else {
        DoRoll(RotateDir);
    }
}
 
function DoRoll(Direct: int) {
    var spinAmount: float = Time.deltaTime * cubeSpeed;
    var t: float;
    var pos: Vector3;
    if (startRotate) {
        if (Direct == 0) {
            NextRot.z += 90;
            RotatePivot = transform.position + new Vector3(-0.5, -0.5, 0);
        } else if (Direct == 1) {
            NextRot.x += 90;
            RotatePivot = transform.position + new Vector3(0, -0.5, 0.5);
        } else if (Direct == 2) {
            NextRot.z -= 90;
            RotatePivot = transform.position + new Vector3(0.5, -0.5, 0);
        } else {
            NextRot.x -= 90;
            RotatePivot = transform.position + new Vector3(0, -0.5, -0.5);
        }
 
        NextRot.z = NextRot.z % 360;
        NextRot.x = NextRot.x % 360;
        totalRotation = 0;
        startRotate = false;
    }
 
    if (beRolling) {
        if (Direct == 0) {
            transform.RotateAround(RotatePivot, Vector3.forward, spinAmount);
        } else if (Direct == 1) {
            transform.RotateAround(RotatePivot, Vector3.right, spinAmount);
        } else if (Direct == 2) {
            transform.RotateAround(RotatePivot, Vector3.forward * -1, spinAmount);
        } else {
            transform.RotateAround(RotatePivot, Vector3.right * -1, spinAmount);
        }
 
        // add to amount of spin in this update the total rotation
        totalRotation += spinAmount;
 
        // check if we have to move to the next edge
        if (totalRotation >= 90) {
 
            // we move to next corner as pivot point
            totalRotation = 0;
            beRolling = false;
            var ri: int = 0;
            var rf: float = transform.eulerAngles.x;
            if (rf < 0) rf = 360 + rf;
            ri = rf / 90.0;
            if ((rf % 90.0) > 45) {
                ri += 1;
            }
            ri = ri * 90;
            transform.eulerAngles.x = ri;
            rf = transform.eulerAngles.y;
            if (rf < 0) rf = 360 + rf;
            ri = rf / 90.0;
            if ((rf % 90.0) > 45) {
                ri += 1;
            }
            ri = ri * 90;
            transform.eulerAngles.y = ri;
            rf = transform.eulerAngles.z;
            if (rf < 0) rf = 360 + rf;
            ri = rf / 90.0;
            if ((rf % 90.0) > 45) {
                ri += 1;
            }
            ri = ri * 90;
            transform.eulerAngles.z = ri;
            transform.position = NextPosi;
            print("rolling OK rotation :" + transform.eulerAngles);
        }
    }
}