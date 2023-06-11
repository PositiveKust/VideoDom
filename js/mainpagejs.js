window.addEventListener('load', (event) => {
	var p_url = location.search.substring(1);
	var parametr = p_url.split("&");
	var values = new Array();
	for(i in parametr) {
		var j=parametr[i].split("=");
		values[j[0]]=unescape(j[1]);
	}
	let main_video_block = document.getElementsByClassName('main-video-block')[0];
	if('video_id' in values){
		InsertMainVideo();
		let video_data; 
		//video_data = loadBytes('/video/'+value['video_id']+'.mp4',InsertMainVideo());
	}

	function InsertMainVideo(){
		document.getElementById('main-video').getElementsByTagName('source')[0].src = 'video/'+values['video_id']+'.mp4';
		// Работа с БД - изменение названия, автора, количества лайков/дизлайков/просмотров видео
		document.getElementById('main-video').load();
		let like_number = document.getElementById('quantity-like');
		let dislike_number = document.getElementById('quantity-dislike');
		let name_video = document.getElementById('name-video-string');
		let autor_video = main_video_block.getElementsByTagName('p')[2];
		let text_video = main_video_block.getElementsByTagName('p')[3];
		name_video.innerHTML = 'Видео ' + values['video_id'];
		autor_video.innerHTML = 'Autor ' + values['video_id'];
		text_video.innerHTML = values['video_id'] + ' ' + values['video_id'] + ' ' + values['video_id'] + ' ' + values['video_id'] + ' ';
	}
});