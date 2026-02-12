const songs=[
    {name:"Song 1",file:"song1.mp3",img:"img1.jpg"}
];

const audio=document.getElementById("audio");
const cover=document.getElementById("cover");
const title=document.getElementById("title");
const playBtn=document.getElementById("playBtn");
const upload=document.getElementById("upload");

let playing=false;
let current=0;

function loadSong(i){
    current=i;
    audio.src=songs[i].file;
    cover.src=songs[i].img;
    title.innerText=songs[i].name;
    play();
}

function play(){
    audio.play();
    cover.style.animationPlayState="running";
    playBtn.innerText="⏸";
    playing=true;
}

function toggle(){
    if(!audio.src){
        loadSong(0);
        return;
    }

    if(playing){
        audio.pause();
        cover.style.animationPlayState="paused";
        playBtn.innerText="▶";
    }else{
        play();
    }
    playing=!playing;
}

function next(){
    current=(current+1)%songs.length;
    loadSong(current);
}

function prev(){
    current=(current-1+songs.length)%songs.length;
    loadSong(current);
}

/* Upload Song */
upload.addEventListener("change",function(){
    const file=this.files[0];
    if(file){
        const url=URL.createObjectURL(file);
        audio.src=url;
        title.innerText=file.name;
        play();
    }
});

/* Download */
function downloadSong(){
    const link=document.createElement("a");
    link.href=audio.src;
    link.download="song.mp3";
    link.click();
}
