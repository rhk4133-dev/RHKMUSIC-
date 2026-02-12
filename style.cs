body{
    margin:0;
    font-family:Arial;
    background:#121212;
    color:white;
}

.container{
    display:flex;
    height:90vh;
}

/* SIDEBAR */
.sidebar{
    width:220px;
    background:#000;
    padding:20px;
}

.sidebar p{
    margin:15px 0;
    color:#b3b3b3;
    cursor:pointer;
}

.sidebar p:hover{
    color:white;
}

/* MAIN */
.main{
    flex:1;
    padding:30px;
    overflow:auto;
}

.song-grid{
    display:grid;
    grid-template-columns:repeat(auto-fill,minmax(180px,1fr));
    gap:20px;
}

.song-card{
    background:#181818;
    padding:15px;
    border-radius:15px;
    cursor:pointer;
    transition:0.3s;
}

.song-card:hover{
    background:#282828;
    transform:scale(1.05);
}

.song-card img{
    width:100%;
    border-radius:10px;
}

.song-card h4{
    margin-top:10px;
}

/* BOTTOM PLAYER */
.bottom-player{
    position:fixed;
    bottom:0;
    width:100%;
    height:90px;
    background:#181818;
    display:flex;
    align-items:center;
    justify-content:space-between;
    padding:10px 20px;
}

.song-info{
    display:flex;
    align-items:center;
}

.song-info img{
    width:60px;
    height:60px;
    border-radius:10px;
    margin-right:15px;
    animation:spin 6s linear infinite;
    animation-play-state:paused;
}

@keyframes spin{
    100%{transform:rotate(360deg);}
}

.controls button{
    margin:0 10px;
    padding:10px 15px;
    background:#1db954;
    border:none;
    border-radius:50%;
    color:white;
    cursor:pointer;
}

.progress-container{
    position:absolute;
    bottom:0;
    left:0;
    width:100%;
    height:5px;
    background:#333;
    cursor:pointer;
}

.progress{
    height:100%;
    width:0%;
    background:#1db954;
}