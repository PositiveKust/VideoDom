window.addEventListener('load', (event) => {
	let search_loop = document.getElementById('search-loop');
	search_loop.onclick = function(){
		SearchVideo();
	}
	function SearchVideo(){
		let value_searching_input = document.getElementById('searching-video').value;
		if( value_searching_input != undefined && value_searching_input != null && value_searching_input != "" ){
			document.location.href ="result_search.html?name_video="+value_searching_input;
		}
	}
});