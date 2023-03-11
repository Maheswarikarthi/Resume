#{
    margin: 0;
    padding: 0;
    font family: sans-serif;
    box-sizing:border-box;

}
h1{
    text-align: center;
    color: black;
    padding: 5px;
}
nav{
    background-color: skyblue;
    display: grid;
    place-items: center;
}
nav ul{
    list-style-type: none;
}
nav ul a{
    display:inline-block;
    padding: 5px;
    text-decoration: none;
    color: black;
    transistion: 0.2s ease-in;

}
nav ul a:hover{
    background-color: skyblue;
    color: white;
}
.items{
    display: grid;
    grid-template-columns: repeat(3, 1fr);
    padding: 30px 20px;
    gird-column-gap: 20px;
    grid-row-gap: 30px;
}
.item img{
    width: 300px;
    height: 300px;
    object-fit: cover;
    cursor: pointer;
    transistion: 0.2s ease;
}
.item img:hover{
    transform: scale(1.04);
}
.item h4{
    padding: 5px;
    text-align: center;
}
.item button{
    padding: 5px 30px;
    border: none;
    outline: none;
    background-color: black;
    color: white;
    cursor: pointer;
    border-radius: 4px;
    font-size: 20px;
    display: block;
    margin: 0 auto;
    transition: 0.2s all;
}
.item button:hover{
    transform: scale(1.06);
}
@media screen and(max-width: 1000px){
    .items{
        grid-template-columns: repeat(2,1fr);
    }
}
@media screen and(max-width: 1000px){
    .items{
        grid-template-columns: repeat(1,1fr);
    }
}
.container
{
    text-align: center;
    font-family: sans-serif;
}