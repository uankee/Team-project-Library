import React, { useEffect, useState } from 'react';
import BookCard from './BookCard';
import { Col, Input, Row } from 'antd';
import image from '../img/Home.png';

function Home() {
  const [books, setBooks] = useState([]);
  const [page, setPage] = useState(1);
  const [searchTerm, setSearchTerm] = useState('');
  const [debouncedSearch, setDebouncedSearch] = useState('');

  useEffect(() => {
    const timeout = setTimeout(() => setDebouncedSearch(searchTerm), 300);
    return () => clearTimeout(timeout);
  }, [searchTerm]);

  useEffect(() => {
    setPage(1);
  }, [debouncedSearch]);

  useEffect(() => {
    fetchBooks();
  }, [page, debouncedSearch]);

  async function fetchBooks() {
    const api = new URL('https://localhost:7167/api/Book');
    api.searchParams.set('pageNumber', page);
    if (debouncedSearch.trim()) {
      api.searchParams.set('searchTerm', debouncedSearch.trim());
    }

    try {
      const response = await fetch(api);

      if (!response.ok) {
        throw new Error(`HTTP error! status: ${response.status}`);
      }

      const data = await response.json();
      setBooks(data);
    } catch (error) {
      console.error('Failed to fetch books:', error);
      setBooks([]);
    }
  }

  function nextPage() {
    setPage((prev) => prev + 1);
  }

  function previousPage() {
    if (page === 1) return;
    setPage((prev) => prev - 1);
  }

  return (
    <div className="home-container baground" style={{ backgroundImage: `url(${image})` }}>
      <h1 className="welcome">Welcome to the Library</h1>

      <div className="home-search">
        <Input
          value={searchTerm}
          onChange={(e) => setSearchTerm(e.target.value)}
          size="large"
          placeholder="Search by title, genre, author or year"
          className="search-input"
          allowClear
        />
      </div>

      <div className="home-buttons">
        <button className="button" onClick={previousPage} style={{ marginRight: 16 }}>
          Previous Page
        </button>
        <button className="button" onClick={nextPage}>
          Next Page
        </button>
      </div>

      {books === null || books.length === 0 ? (
        <h1
          style={{
            textAlign: 'center',
            color: 'white',
            fontSize: '48px',
            paddingTop: '60px',
            margin: 0,
            marginBottom: '0',
          }}
        >
          Books not found
        </h1>
      ) : (
        <div className="cards">
          <Row gutter={[24, 24]} justify="center">
            {books.map((book) => (
              <Col key={book.id}>
                <BookCard Book={book} />
              </Col>
            ))}
          </Row>
        </div>
      )}
    </div>
  );
}

export default Home;
