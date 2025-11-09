import React, { cloneElement, useEffect, useState } from 'react';
import BookCard from './BookCard';
import { Button, Col, Row } from 'antd';

function Home() {

    const[books, setBooks] = useState([]);
    const[page, setPage] = useState(1);

    useEffect(() => {
        fetchBooks();
    }, [page]);

    async function fetchBooks() {
        const api = `http://localhost:5162/api/Book?pageNumber=${page}`;

        const response = await fetch(api)
        const data = await response.json();

        console.log(data)

        setBooks(data);
    }

    function NextPage() {
        setPage(prev => prev + 1);
    }

    function PreviousPage() {
        if(page === 1)
            return;

        setPage(prev => prev - 1);
    }

  return (
    <div className="home-containe" >
        <div className='home-baground'>

        <h1 className='welcome'>W<span style={{color: "black"}}>elco</span>me to the Library</h1>

        <div className='home-buttons'>
            <button className='button' onClick={PreviousPage} style={{marginRight: 6}}>Previous Page</button>
            <button className='button' onClick={NextPage}>Next Page</button>
        </div>

        { 
            books === null || books.length === 0 
            ? <h1 style={{textAlign: 'center', color: 'white', fontSize: "64px", paddingTop: '100px', margin: '0', marginBottom: '0'}}>
                Books not found</h1>
            : 
            <div className="cards">
                <Row gutter={[0, 0]}>
                    {books.map(book => (
                        <Col key={book.id} span={4.5}>
                            <BookCard Book={book} />
                        </Col>
                    ))}
                </Row>
            </div> 
        }
        </div>
    </div>
  );
};

export default Home;
