import { useEffect, useState } from "react";
import image from "../img/BookPage.png"
import { useParams } from "react-router-dom";

function BookPage() {

    const { id } = useParams();
    const [book, setBook] = useState()
    const [review, setReview] = useState([])
    const [author, setAuthor] = useState()
    const [genre, setGenre] = useState()

    useEffect(() => {
        fetchData(`https://localhost:7167/api/Book/${id}`, setBook);
    }, [id]);

    useEffect(() => {
        if (!book) return;
        fetchData(`https://localhost:7167/api/Genre/${book.genreId}`, setGenre);
        fetchData(`https://localhost:7167/api/Author/${book.authorId}`, setAuthor);
        fetchData(`https://localhost:7167/api/Review?bookTitle=${encodeURIComponent(book.title)}&pageNumber=1`, setReview);
    }, [book]);


    async function fetchData(url, setState) {
        try {
            const response = await fetch(url);
            const data = await response.json();
            setState(data);
            console.log(data);
        } catch (err) {
            console.error("Error fetching data:", err);
        }
    }

    return (
    <div className="book-page baground" style={{ backgroundImage: `url(${image})` }}>
        {book ? (
        <>
            <div className="image-container">
            <img
                src={book.coverImage}
                alt={book.title}
                className="book-info-image"
            />
            </div>

            <div className="book-info" style={{height: 550, width: 700, marginRight: 50}}>
                <p>Title: {book.title}</p>
                <p>Published Date: {book.publishedDate.slice(0, 10)}</p>
                <p>Available Copies: {book.availableCopies}</p>
                <p>Author: {author?.name}</p>
                <p>Genre: {genre?.name}</p>
            </div>

            <div className="book-info" style={{height: 537, width: 400, overflowY: 'visible'}}>
            {review && review.length > 0 ? (
                review.map((r, index) => (
                <div
                key={index}
                style={{
                    marginBottom: 9,
                    padding: 7,
                    marginLeft: -20,
                    borderRadius: 20,
                    border: '1px solid rgba(255, 255, 255, 0.3)', 
                    color: 'white',
                    fontSize: 14,
                    lineHeight: 1.4,
                    textAlign: 'left',
                }}
                >
                <div style={{display: 'flex', justifyContent: 'space-between', marginBottom: 4}}>
                    <strong>{r.userName}</strong>
                    <span style={{color: '#00c6fb'}}>⭐ {r.rating}</span>
                </div>
                <p style={{margin: '2px 0'}}>{r.comment}</p>
                <p style={{fontSize: 12, color: 'rgba(255,255,255,0.6)'}}>
                {r.createdAt?.slice(0, 10)} {r.createdAt?.slice(11, 19)}
                </p>
                </div>
                ))
            ) : (
                <p style={{textAlign: 'center'}}>Review not found</p>
            )}
            </div>
        </>
        ) : (
        <p>Loading...</p>
        )}
    </div>
    );}

export default BookPage;