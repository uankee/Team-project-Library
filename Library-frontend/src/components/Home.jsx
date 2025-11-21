import React, { useEffect, useState } from 'react';
import BookCard from './BookCard';
import { Col, Input, Row, Spin } from 'antd';
import image from '../img/Home.png';

function Home() {
    const [books, setBooks] = useState([]);
    const [page, setPage] = useState(1);
    const [searchTerm, setSearchTerm] = useState('');
    const [isLoading, setIsLoading] = useState(false);

    useEffect(() => {
        const debounce = setTimeout(() => {
            fetchBooks();
        }, 300);

        return () => clearTimeout(debounce);
    }, [page, searchTerm]);

    async function fetchBooks() {
        const api = new URL('https://localhost:7167/api/Book');
        api.searchParams.set('pageNumber', page);

        if (searchTerm.trim()) {
            api.searchParams.set('searchTerm', searchTerm.trim());
        }

        try {
            setIsLoading(true);
            const response = await fetch(api);

            if (!response.ok) {
                throw new Error(`HTTP error! status: ${response.status}`);
            }

            const data = await response.json();
            setBooks(data);
        } catch (error) {
            console.error('Failed to fetch books:', error);
            setBooks([]);
        } finally {
            setIsLoading(false);
        }
    }

    function NextPage() {
        setPage(prev => prev + 1);
    }

    function PreviousPage() {
        if (page === 1)
            return;

        setPage(prev => prev - 1);
    }

    return (
        <div className="home-container baground" style={{ backgroundImage: `url(${image})` }}>
            <h1 className='welcome'>Welcome to the Library</h1>

            <div style={{ display: 'flex', justifyContent: 'center', marginTop: 40 }}>
                <Input.Search
                    placeholder="Search by title, genre, author or year..."
                    allowClear
                    size="large"
                    value={searchTerm}
                    onChange={(e) => {
                        setPage(1);
                        setSearchTerm(e.target.value);
                    }}
                    style={{ width: 600 }}
                />
            </div>

            <div className='home-buttons'>
                <button className='button' onClick={PreviousPage} style={{ marginRight: 16 }}>Previous Page</button>
                <button className='button' onClick={NextPage}>Next Page</button>
            </div>

            {
                isLoading ? (
                    <div style={{ display: 'flex', justifyContent: 'center', paddingTop: 100 }}>
                        <Spin size="large" />
                    </div>
                ) : books === null || books.length === 0
                    ? <h1 style={{ textAlign: 'center', color: 'white', fontSize: "48px", paddingTop: '80px', margin: '0', marginBottom: '0' }}>
                        Books not found</h1>
                    :
                    <div className="cards">
                        <Row gutter={[16, 16]} justify="start">
                            {books.map(book => (
                                <Col key={book.id} xs={24} sm={12} md={8} lg={6} xl={6} xxl={4}>
                                    <BookCard Book={book} />
                                </Col>
                            ))}
                        </Row>
                    </div>
            }
        </div>
    );
};

export default Home;
