
	
	var scene, camera, renderer, mesh;
	
    var meshFloor, ambientLight, light;

    var crate, crateTexture, crateNormalMap, crateBumpMap;

    var keyboard = {};
	
    var player = { height:1.8, speed:0.2, turnSpeed:Math.PI*0.02 };
	
    var USE_WIREFRAME = false;

    function init(){
	    scene = new THREE.Scene();
	    scene.background = new THREE.Color( 0x000000 );
	    camera = new THREE.PerspectiveCamera(60, window.innerWidth / window.innerHeight, 1, 1000);


	    var textureLoader = new THREE.TextureLoader();
	
	crateTexture = textureLoader.load("/Content/images/grass-texture.jpg");
	
	meshFloor = new THREE.Mesh(
		new THREE.PlaneGeometry(20,20, 10,10),
		new THREE.MeshPhongMaterial({color:0x444444, wireframe:USE_WIREFRAME})
	);
	
	meshFloor.rotation.x -= Math.PI / 2;
	meshFloor.receiveShadow = true;
	scene.add(meshFloor);
	
	ambientLight = new THREE.AmbientLight(0xffffff, 2);
	scene.add(ambientLight);

	
	// Model/material loading!
	var mtlLoader = new THREE.MTLLoader();

	mtlLoader.load("/Content/models/36f3395e75ea4915868fbe1b0c47b00c.blend.mtl", function(materials){
		
	   materials.preload();
	
	   var objLoader = new THREE.OBJLoader();
	   objLoader.setMaterials(materials);
	   objLoader.load("/Content/models/36f3395e75ea4915868fbe1b0c47b00c.blend.obj", function(mesh){
		
	       mesh.traverse(function(node){
		   if( node instanceof THREE.Mesh ){
					node.castShadow = true;
					node.receiveShadow = true;
				}
			});
		
			scene.add(mesh);
			mesh.position.set(0, 0, 0);
			mesh.rotation.y = -Math.PI/4;
		});
		
	});


	camera.position.set(-15, player.height, 5);
	camera.lookAt(new THREE.Vector3(0,player.height,0));
	
	renderer = new THREE.WebGLRenderer();
	renderer.setSize(1280, 720);

	renderer.shadowMap.enabled = true;
	renderer.shadowMap.type = THREE.BasicShadowMap;

	document.body.appendChild(renderer.domElement);
	
	renderer.domElement.addEventListener('mousedown', function(event) {
    var vector = new THREE.Vector3(
        renderer.devicePixelRatio * (event.pageX - this.offsetLeft) / this.width * 2 - 1,
        -renderer.devicePixelRatio * (event.pageY - this.offsetTop) / this.height * 2 + 1,
        0
    );

    projector.unprojectVector(vector, camera);

    var raycaster = new THREE.Raycaster(
        camera.position,
        vector.sub(camera.position).normalize()
    );

    var intersects = raycaster.intersectObjects(OBJECTS);
    if (intersects.length) {
        console.log(intersects[0]);
    }
}, false);

	animate();
}

function animate(){
	requestAnimationFrame(animate);

	
	if(keyboard[83]){ // W key
		camera.position.x += Math.sin(camera.rotation.y) * player.speed;
		camera.position.z -= -Math.cos(camera.rotation.y) * player.speed;
	}
	if(keyboard[87]){ // S key
		camera.position.x -= Math.sin(camera.rotation.y) * player.speed;
		camera.position.z += -Math.cos(camera.rotation.y) * player.speed;
	}
	if(keyboard[65]){ // A key
		camera.position.x -= Math.sin(camera.rotation.y + Math.PI/2) * player.speed;
		camera.position.z += -Math.cos(camera.rotation.y + Math.PI/2) * player.speed;
	}
	if(keyboard[68]){ // D key
		camera.position.x -= Math.sin(camera.rotation.y - Math.PI/2) * player.speed;
		camera.position.z += -Math.cos(camera.rotation.y - Math.PI/2) * player.speed;
	}
	
	if(keyboard[37]){ // left arrow key
		camera.rotation.y += player.turnSpeed;
	}
	if(keyboard[39]){ // right arrow key
		camera.rotation.y -= player.turnSpeed;
	}
	
	renderer.render(scene, camera);
}

function keyDown(event){
	keyboard[event.keyCode] = true;
}

function keyUp(event){
	keyboard[event.keyCode] = false;
}

function showParameters(){
	    camera.position.x += 5;
	}




   
window.addEventListener('keydown', keyDown);
window.addEventListener('keyup', keyUp);
window.onload = init()
